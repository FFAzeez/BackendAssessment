using BackendAssessmentInfrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAssessmentInfrastructure.Context
{
    public class BackendContext : DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options):base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
