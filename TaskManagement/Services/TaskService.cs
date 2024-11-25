using AutoMapper;
using BoilerPlate.Utils;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskManagement.Data;
using TaskManagement.Entities;
using TaskManagement.Interfaces.Services;
using TaskManagement.Models.Common;
using TaskManagement.Models.Label.Query;
using TaskManagement.Models.Task.Command;
using TaskManagement.Models.Task.Query;
using TaskManagement.Models.User.Query;
using TaskManagement.Utils.Dtos;

namespace TaskManagement.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TaskService(IMapper mapper, AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Assign(TaskCommandDto taskCommand)
        {
            // Lấy UserId từ HttpContext.User
            var userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                throw new Exception("Bạn chưa đăng nhập !");
            }
            var currentUserId = int.Parse(userIdClaim.Value);
            
            var task = new TblTask()
            {
                Title = taskCommand.Title,
                Code = taskCommand.Code,
                Description = taskCommand.Description,
                Priority = taskCommand.SelectedPriority,
                StartDate = taskCommand.StartDate,
                EndDate = taskCommand.EndDate,
                EstimatedTime = taskCommand.EstimatedTime,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = currentUserId,
                ParentId = taskCommand.ParentId,
                TaskLabels = taskCommand.SelectedLabelIds.Select(labelId => new TaskLabel()
                {
                    LabelId = labelId,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = 0,
                }).ToList(),
                TaskUsers = taskCommand.SelectedUserIds.Select(userId => new TaskUser()
                {
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = 0,
                }).ToList(),

                Status = enums.TaskStatus.Assigned,
            };

            //task.TaskFiles = taskCommand.Files.Select(userId => new TaskUser()
            //{
            //    UserId = userId,
            //    CreatedAt = DateTime.UtcNow,
            //    CreatedBy = 0,
            //}).ToList();

            await _context.AddAsync(task);

            //foreach (var userId in taskCommand.UserIds)
            //{

            //    var taskUser = new TaskUser()
            //    {
            //        UserId = userId,
            //        CreatedAt = DateTime.UtcNow,
            //        CreatedBy = 0,
            //    };
            //    task.TaskUsers.Add(taskUser);
            //}

            //foreach (var labelId in taskCommand.LabelIds)
            //{
            //    var taskLabel = new TaskLabel()
            //    {
            //        LabelId = labelId,
            //        CreatedAt = DateTime.UtcNow,
            //        CreatedBy = 0,
            //    };
            //    task.TaskLabels.Add(taskLabel);

            //}

            //var res = await _context.SaveChangesAsync() > 0;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(IEnumerable<int> ids)
        {
            if (!ids.Any())
                throw new CustomException("Dữ liệu không hợp lệ !");

            var tasks = await _context.Tasks.Where(e => ids.Contains(e.Id)).ToListAsync();

            if (tasks.Any())
                throw new NotFoundException("Không tìm thấy dữ liệu để xóa !");

            _context.RemoveRange(tasks);

            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<PagedResult<TaskQueryDto>> GetAllPaging(TaskPagingRequest request)
        {
            //var query = from t in _context.Tasks
            //            join tl in _context.TaskLabels on t.Id equals tl.TaskId into ttl
            //            from tl in ttl.DefaultIfEmpty()
            //            join l in _context.Labels on tl.LabelId equals l.Id into tll
            //            from l in tll.DefaultIfEmpty()
            //            join tu in _context.TaskUsers on t.Id equals tu.TaskId into ttu
            //            from tu in ttu.DefaultIfEmpty()
            //            join u in _context.Users on tu.UserId equals u.Id into tuu
            //            from u in tuu.DefaultIfEmpty()
            //            join c in _context.Users on t.CreatedBy equals c.Id into tc
            //            from c in tc.DefaultIfEmpty()
            //            where t.Code != null
            //            select new { t, l, };

            var query = from task in _context.Tasks
                        join user in _context.Users
                            on task.CreatedBy equals user.Id into userGroup
                        from user in userGroup.DefaultIfEmpty() // Đảm bảo LEFT JOIN
                        select new TaskQueryDto
                        {
                            Id = task.Id,
                            Title = task.Title,
                            Description = task.Description,
                            StartDate = task.StartDate,
                            EndDate = task.EndDate,
                            Priority = task.Priority,
                            EstimatedTime = task.EstimatedTime,
                            Status = task.Status,
                            CreatedAt = task.CreatedAt,
                            CreatedBy = task.CreatedBy,
                            CreatedByName = user != null ? user.UserName : null,
                            Labels = task.TaskLabels.Select(tl => new LabelQueryDto
                            {
                                Id = tl.Label.Id,
                                Name = tl.Label.Name,
                                Color = tl.Label.Color
                            }).ToList(),
                            Users = task.TaskUsers.Select(tu => new UserQueryDto
                            {
                                Id = tu.User.Id,
                                UserName = tu.User.UserName,
                                Email = tu.User.Email,
                                PhoneNumber = tu.User.PhoneNumber,
                            }).ToList()
                        };



            if (!string.IsNullOrWhiteSpace(request.Keyword))
            {
                query = query.Where(e => e.Title.ToLower().Contains(request.Keyword.ToLower())
                    || e.Description.ToLower().Contains(request.Keyword.ToLower()));
            }

            if (request.Priority.HasValue)
            {
                query = query.Where(e => e.Priority == request.Priority.Value);
            }

            if (request.Status.HasValue)
            {
                query = query.Where(e => e.Status.ToString().ToLower() == request.Status.Value.ToString().ToLower());
            }

            query = query.OrderBy(e => e.CreatedAt);

            int totalRecords = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize).ToListAsync();
            var pagedResult = new PagedResult<TaskQueryDto>()
            {
                TotalRecords = totalRecords,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<TaskQueryDto> GetById(int id)
        {
            var query = await (from task in _context.Tasks
                             join user in _context.Users
                                 on task.CreatedBy equals user.Id into userGroup
                             from user in userGroup.DefaultIfEmpty() // Đảm bảo LEFT JOIN
                             select new TaskQueryDto
                             {
                                 Id = task.Id,
                                 Title = task.Title,
                                 Description = task.Description,
                                 StartDate = task.StartDate,
                                 EndDate = task.EndDate,
                                 Priority = task.Priority,
                                 EstimatedTime = task.EstimatedTime,
                                 Status = task.Status,
                                 CreatedAt = task.CreatedAt,
                                 CreatedBy = task.CreatedBy,
                                 CreatedByName = user != null ? user.UserName : null,
                                 Labels = task.TaskLabels.Select(tl => new LabelQueryDto
                                 {
                                     Id = tl.Label.Id,
                                     Name = tl.Label.Name,
                                     Color = tl.Label.Color
                                 }).ToList(),
                                 Users = task.TaskUsers.Select(tu => new UserQueryDto
                                 {
                                     Id = tu.User.Id,
                                     UserName = tu.User.UserName,
                                     Email = tu.User.Email,
                                     PhoneNumber = tu.User.PhoneNumber,
                                 }).ToList()
                             }).FirstOrDefaultAsync()
                ?? throw new CustomException("");

            return query;
        }

        public Task<bool> Update(int id, TaskCommandDto taskCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStatus(int id, int status)
        {
            throw new NotImplementedException();
        }

    }
}
