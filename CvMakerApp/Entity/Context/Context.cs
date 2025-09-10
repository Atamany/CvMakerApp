using Microsoft.EntityFrameworkCore;

namespace CvMakerApp.Entity.Context
{
    public class Context : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YIGITATAMANPC;initial catalog=CvMakerDB;integrated Security=true; TrustServerCertificate=True");
        }
        public DbSet<Entities.Stack> Stacks { get; set; }
        public DbSet<Entities.Voluntary> Voluntaries { get; set; }
        public DbSet<Entities.Language> Languages { get; set; }
        public DbSet<Entities.Description> Descriptions { get; set; }
        public DbSet<Entities.Testimonial> Testimonials { get; set; }
        public DbSet<Entities.Education> Educations { get; set; }
        public DbSet<Entities.Title> Titles { get; set; }
        public DbSet<Entities.Experience> Experiences { get; set; }
        public DbSet<Entities.Membership> Memberships { get; set; }


    }
}
