using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Test.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<Test.Models.Departments> Departments { get; set; } = default!;
        public DbSet<Test.Models.Majors> Majors { get; set; } = default!;
        public DbSet<Test.Models.Subjects> Subjects { get; set; } = default!;
    }
}
