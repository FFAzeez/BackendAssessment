using BackendAssessmentCore.DTO.Request;
using BackendAssessmentCore.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssessmentCore.Services.Interface
{
    public interface IAuthenticationServices
    {
        Task<Response<UserResponseDto>> OnboardCustomer(UserRequestDto userRequest);
    }
}
