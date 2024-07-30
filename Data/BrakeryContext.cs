using Microsoft.EntityFrameworkCore;
using Brakery.Models;
using Brakery.Data.Configurations;

namespace Brakery.Data;

public class BrakeryContext:DbContext
{
    public DbSet<Product> Products{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlite(@"Data source=Brakey.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
    }
}
