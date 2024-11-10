using AutoMapper;
using TaskManagement.Entities;
using TaskManagement.Models.Task.Command;
using TaskManagement.Models.Task.Query;
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
