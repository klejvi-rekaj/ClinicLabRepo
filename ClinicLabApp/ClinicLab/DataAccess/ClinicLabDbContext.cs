using ClinicLab.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicLab.DataAccess
{
    public class ClinicLabDbContext : DbContext
    {
        
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KVN\\SQLEXPRESS01;Database=FormsTestDB;Trusted_Connection=True;");
        }

    }
}


