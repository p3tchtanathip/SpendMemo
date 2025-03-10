using Microsoft.EntityFrameworkCore;
using SpendMemo.Models;

namespace SpendMemo.Data
{
  public class SpendMemoContext : DbContext
  {
    public SpendMemoContext(DbContextOptions<SpendMemoContext> options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
  }
}