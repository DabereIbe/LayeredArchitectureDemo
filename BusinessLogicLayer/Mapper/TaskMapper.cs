using AutoMapper;
using BusinessLogicLayer.DomainModels.Tasks;
using DataAccessLayer.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class TaskMapper : Profile
    {
        public TaskMapper() 
        {
            CreateMap<Tasks, TasksReadDto>();
            CreateMap<TasksCreateDto, Tasks>();
        }
    }
}
