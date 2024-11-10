using AutoMapper;
using BoilerPlate.Utils;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Interfaces.Services;
using TaskManagement.Models.Requests.List;
using TaskManagement.Models.Requests.Task.Command;
using TaskManagement.Models.Requests.Task.Query;
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

        public Task<bool> Assign(TaskCommandDto taskCommand)
        {
            //var task = _mapper.Map<TblTask>(taskCommand);
            //task.CreatedAt = DateTime.UtcNow;
            ////task.CreatedBy = ;
            //await _taskRepository.AddAsync(task);

            //var res = await _taskRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}

            //foreach (var userId in taskCommand.UserIds)
            //{
            //    var taskUser = new TaskUser()
            //    {
            //        TaskId = task.Id,
            //        UserId = userId,
            //        CreatedAt = DateTime.UtcNow,
            //        //CreatedBy = ;
            //    };
            //    await _taskUserRepository.AddAsync(taskUser);
            //}

            //res = await _taskUserRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}

            //foreach (var labelId in taskCommand.LabelIds)
            //{
            //    var taskLabel = new TaskLabel()
            //    {
            //        TaskId = task.Id,
            //        LabelId = labelId,
            //        CreatedAt = DateTime.UtcNow,
            //        //CreatedBy = ;
            //    };
            //    await _taskLabelRepository.AddAsync(taskLabel);

            //}

            //res = await _taskLabelRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}

            //return res;

            throw new NotImplementedException();


        }

        public Task<bool> Delete(IEnumerable<int> ids)
        {
            //if (!ids.Any())
            //    throw new CustomException("Dữ liệu không hợp lệ !");

            //var tasks = (await _taskRepository.GetWhereAsync(e => ids.Contains(e.Id))).ToList();

            //if (tasks.Any())
            //    throw new CustomException("Không tìm thấy dữ liệu để xóa !");

            //await _taskRepository.RemoveRangeAsync(tasks);

            //var res = await _taskLabelRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}
            //var taskUsers = (await _taskUserRepository.GetWhereAsync(e => ids.Contains(e.TaskId))).ToList();
            //await _taskUserRepository.RemoveRangeAsync(taskUsers);
            //res = await _taskLabelRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}
            //var taskLabels = (await _taskLabelRepository.GetWhereAsync(e => ids.Contains(e.TaskId))).ToList();
            //await _taskLabelRepository.RemoveRangeAsync(taskLabels);
            //res = await _taskLabelRepository.CommitAsync() > 0;
            //if (res)
            //{
            //    throw new CustomException("Có lỗi xảy ra khi giao việc !");
            //}

            //return res;
            throw new NotImplementedException();


        }


        public Task<PagedResult<TaskQueryDto>> GetAllPaging(int? labelId, int? userId, string keyword, ListRequestModel request)
        {
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
