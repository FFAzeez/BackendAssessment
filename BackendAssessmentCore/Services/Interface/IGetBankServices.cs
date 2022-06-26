using BackendAssessmentCore.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssessmentCore.Services.Interface
{
    public interface IGetBankServices
    {
        Task<Response<ListGetbankDto>> GetbankRequest();
    }
}
