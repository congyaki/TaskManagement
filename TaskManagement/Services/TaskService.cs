using AutoMapper;
using BoilerPlate.Utils;
using NuGet.Protocol.Core.Types;
using TaskManagement.Entities;
using TaskManagement.Interfaces.Repositories;
using TaskManagement.Interfaces.Services;
using TaskManagement.Models.Requests.List;
using TaskManagement.Models.Requests.Task.Command;
using TaskManagement.Models.Requests.Task.Query;
using X.PagedList;

namespace TaskManagement.Services
{
    public class TaskService : ITaskService
    {
        private readonly IBaseRepository<TblTask, int> _taskRepository;
        private readonly IBaseRepository<TaskUser, int> _taskUserRepository;
        private readonly IBaseRepository<TaskLabel, int> _taskLabelRepository;
        private readonly IMapper _mapper;

        public TaskService(IBaseRepository<TblTask, int> repository, IMapper mapper, IBaseRepository<TaskUser, int> taskUserRepository, IBaseRepository<TaskLabel, int> taskLabelRepository)
        {
            _taskRepository = repository;
            _mapper = mapper;
            _taskUserRepository = taskUserRepository;
            _taskLabelRepository = taskLabelRepository;
        }

        public async Task<bool> AssignTask(TaskCommandDto taskCommand)
        {
            if (taskCommand is null)
                throw new Exception("Dữ liệu không hợp lệ !");

            var task = _mapper.Map<TblTask>(taskCommand);
            task.CreatedAt = DateTime.UtcNow;
            //task.CreatedBy = ;
            await _taskRepository.AddAsync(task);

            var res = await _taskRepository.CommitAsync() > 0;
            if (res)
            {
                throw new CustomException("Có lỗi xảy ra khi giao việc !");
            }

            foreach (var userId in taskCommand.UserIds)
            {
                var taskUser = new TaskUser()
                {
                    TaskId = task.Id,
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow,
                    //CreatedBy = ;
                };
                await _taskUserRepository.AddAsync(taskUser);
            }

            res = await _taskUserRepository.CommitAsync() > 0;
            if (res)
            {
                throw new CustomException("Có lỗi xảy ra khi giao việc !");
            }

            foreach (var labelId in taskCommand.LabelIds)
            {
                var taskLabel = new TaskLabel()
                {
                    TaskId = task.Id,
                    LabelId = labelId,
                    CreatedAt = DateTime.UtcNow,
                    //CreatedBy = ;
                };
                await _taskLabelRepository.AddAsync(taskLabel);

            }

            res = await _taskLabelRepository.CommitAsync() > 0;
            if (res)
            {
                throw new CustomException("Có lỗi xảy ra khi giao việc !");
            }

            return res;
        }

        public async Task<bool> DeleteTask(IEnumerable<int> ids)
        {
            if (!ids.Any())
                throw new CustomException("Dữ liệu không hợp lệ !");

            var tasks = (await _taskRepository.GetWhereAsync(e => ids.Contains(e.Id))).ToList();

            if (tasks.Any())
                throw new CustomException("Không tìm thấy dữ liệu để xóa !");
            foreach (var task in tasks)
            {
                await _taskRepository.RemoveAsync(task);
            }

            throw new Exception();
        }

        public Task<TaskQueryDto> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<TaskQueryDto>> GetListTask(ListRequestModel request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStatusOfTask(int id, int status)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTask(int id, TaskCommandDto taskCommand)
        {
            throw new NotImplementedException();
        }
    }
}
