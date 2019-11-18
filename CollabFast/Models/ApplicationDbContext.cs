using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CollabFast.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}