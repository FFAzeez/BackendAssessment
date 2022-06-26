using BackendAssessmentCore.Implementation.Services;
using BackendAssessmentCore.Services.Implementation;
using BackendAssessmentCore.Services.Interface;
using BackendAssessmentCore.Utility;
using BackendAssessmentInfrastructure.Repositories.Implementation;
using BackendAssessmentInfrastructure.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace BackendAssessment.Extension
{
    public static class ServiceConfiguration
    {
        public static void AddServicesConfiguration(this IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IAuthenticationServices, AuthenticationServices>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IConfirmStateLGA, ConfirmStateLGA>();
            service.AddScoped<IGetBankServices, GetBankServices>();
        }
    }
}
