using MediPlusMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MediPlusMVC.DAL.Contexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
