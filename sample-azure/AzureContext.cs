using Microsoft.EntityFrameworkCore;

public class AzureContext : DbContext
{
    // public DbSet<Blog> Blogs { get; set; }
    // public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            
    }
}