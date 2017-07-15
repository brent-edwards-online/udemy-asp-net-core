namespace CourseProjectApp.EntityModels
{
    using Microsoft.EntityFrameworkCore;

    public class CourseProjectAppDbContext : DbContext
    {
        public CourseProjectAppDbContext(DbContextOptions<CourseProjectAppDbContext> options): base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Register> Register { get; set; }
    }
}
