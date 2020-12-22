using Microsoft.EntityFrameworkCore;

namespace TrackingBlocksAPI.Models
{
  public class BlacksContext : DbContext
  {
    public DbSet<Block> Blocks { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlite("Data Source=blocks.db");
  }
}