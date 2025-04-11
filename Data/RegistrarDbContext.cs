using Microsoft.EntityFrameworkCore;

namespace Registrar;

public class RegistrarDbContext : DbContext
{
    public RegistrarDbContext(DbContextOptions<RegistrarDbContext> options) : base(options) { }
    
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Registration> Registrations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Course)
            .WithMany(c => c.Registrations)
            .HasForeignKey(r => r.CourseId);
        
        modelBuilder.Entity<Registration>()
            .HasOne<Student>(r => r.Student)
            .WithMany(s => s.Registrations)
            .HasForeignKey(r => r.StudentId);
    }
}