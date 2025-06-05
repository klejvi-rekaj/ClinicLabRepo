using ClinicLab.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicLab.DataAccess
{
    public class ClinicLabDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-0KTCT61P;Database=ClinicLabertaDb;Trusted_Connection=True;");
        }
    }
}



