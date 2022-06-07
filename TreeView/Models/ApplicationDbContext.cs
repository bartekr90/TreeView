using System.Data.Entity;

namespace TreeView.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
                    : base("DefaultConnection")
        {
        }

        public DbSet<Section> Sections { get; set; }
    }
}