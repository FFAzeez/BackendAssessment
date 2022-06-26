using AutoMapper;
using BackendAssessmentCore.DTO.Request;
using BackendAssessmentCore.DTO.Response;
using BackendAssessmentInfrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssessmentCore.DTO.Mapping
{
    public class UserMapping:Profile
    {
        public UserMapping()
        {
            CreateMap<UserResponseDto,Customer>().ReverseMap();
            CreateMap<UserRequestDto, Customer>().ReverseMap();
        }
    }
}
