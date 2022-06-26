using BackendAssessmentCore.DTO.Response;
using BackendAssessmentCore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssessmentCore.Services.Interface
{
    public interface IUserService
    {
        Task<Response<PaginationModel<IEnumerable<UserResponseDto>>>> GetAllOnboarded(int pageSize, int pageNumber);
    }
}
