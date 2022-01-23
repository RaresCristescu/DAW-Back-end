using AutoMapper;
using proiect.Models;
using proiect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities
{
    public class MapperProfiles:Profile
    {
        public MapperProfiles()
        {
            CreateMap<Student, ModelResultDTO>();
            CreateMap<ModelResultDTO,Student>();

            CreateMap<Student, ModelResultDTO>()
                .ForMember(dest => dest.StudentId, opts => opts.MapFrom(source => source.Id));
        }
    }
}
