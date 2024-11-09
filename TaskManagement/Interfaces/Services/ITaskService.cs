using TaskManagement.Models.Requests.List;
using TaskManagement.Models.Requests.Task.Command;
using TaskManagement.Models.Requests.Task.Query;
using X.PagedList;

namespace TaskManagement.Interfaces.Services
{
    public interface ITaskService
    {
        Task<bool> AssignTask(TaskCommandDto taskCommand);
        Task<bool> UpdateTask(int id, TaskCommandDto taskCommand);
        Task<bool> DeleteTask(IEnumerable<int> ids);
        Task<bool> UpdateStatusOfTask(int id, int status);
        Task<IPagedList<TaskQueryDto>> GetListTask(ListRequestModel request);
        Task<TaskQueryDto> GetDetail(int id);
    }
}
