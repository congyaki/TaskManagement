using AutoMapper;
using TaskManagement.Entities;
using TaskManagement.Models.Requests.Task.Command;
using TaskManagement.Models.Requests.Task.Query;
using TblTask = TaskManagement.Entities.TblTask;

namespace TaskManagement.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskCommandDto, TblTask>();
            CreateMap<TblTask, TaskQueryDto>();

        }
    }
}
