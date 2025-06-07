using ClinicLab.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicLab.DataAccess
{
    public class ClinicLabDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ClinicLabDbContext(DbContextOptions<ClinicLabDbContext> options)
            : base(options) { }
    }
}



