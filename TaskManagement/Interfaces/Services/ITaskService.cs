using TaskManagement.Models.Requests.List;
using TaskManagement.Models.Requests.Task.Command;
using TaskManagement.Models.Requests.Task.Query;
using TaskManagement.Utils.Dtos;
using X.PagedList;

namespace TaskManagement.Interfaces.Services
{
    public interface ITaskService
    {
        Task<bool> Assign(TaskCommandDto taskCommand);
        Task<bool> Update(int id, TaskCommandDto taskCommand);
        Task<bool> Delete(IEnumerable<int> ids);
        Task<bool> UpdateStatus(int id, int status);
        Task<PagedResult<TaskQueryDto>> GetAllPaging(int? labelId, int? userId, string keyword, ListRequestModel request);
        Task<TaskQueryDto> GetById(int id);
    }
}
