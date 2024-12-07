using Microsoft.EntityFrameworkCore;
using StudentRecord.Models;

namespace StudentRecord.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student>Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId=1, StudentName="Harshit", StudentClass=12 },
                new Student { StudentId = 2, StudentName = "HEHE", StudentClass = 11 },
                new Student { StudentId = 3, StudentName = "PEPE", StudentClass = 10 },
                new Student { StudentId = 4, StudentName = "POPO", StudentClass = 9 },
                new Student { StudentId = 5, StudentName = "GG", StudentClass = 8 }
                );
        }
    }
}
