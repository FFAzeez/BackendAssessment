using BackendAssessmentInfrastructure.Context;
using BackendAssessmentInfrastructure.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackendAssessment.Extension
{
    public static class ExtensionConfiguration
    {
        public static void AddDbConfiguration(this IServiceCollection service, IConfiguration configuration) => 
            service.AddDbContext<BackendContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default")));
    }
}
