using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendAssessmentCore.Utility
{
    public interface IConfirmStateLGA
    {
        Task<bool> Confirmation(string state, string lga);
    }
}