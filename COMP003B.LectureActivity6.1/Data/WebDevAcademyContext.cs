using Microsoft.EntityFrameworkCore;
using COMP003B.LectureActivity6._1.Models;

namespace COMP003B.LectureActivity6._1.Data
{
    public class WebDevAcademyContext : DbContext 
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
