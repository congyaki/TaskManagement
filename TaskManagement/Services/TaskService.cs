using AutoMapper;
using BoilerPlate.Utils;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Entities;
using TaskManagement.Interfaces.Services;
using TaskManagement.Models.Common;
using TaskManagement.Models.Task.Command;
using TaskManagement.Models.Task.Query;
using TaskManagement.Utils.Dtos;

namespace TaskManagement.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public TaskService(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> Assign(TaskCommandDto taskCommand)
        {
            var task = _mapper.Map<TblTask>(taskCommand);
            task.CreatedAt = DateTime.UtcNow;
            task.CreatedBy = 0;
            task.TaskLabels = taskCommand.LabelIds.Select(labelId => new TaskLabel()
            {
                LabelId = labelId,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = 0,
            }).ToList();
            task.TaskUsers = taskCommand.UserIds.Select(userId => new TaskUser()
            {
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = 0,
            }).ToList();
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


        public Task<PagedResult<TaskQueryDto>> GetAllPaging(TaskPagingRequest pagingRequest)
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
            //            select new {t, l, }

            throw new NotImplementedException();

        }

        public Task<TaskQueryDto> GetById(int id)
        {
            throw new NotImplementedException();
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
