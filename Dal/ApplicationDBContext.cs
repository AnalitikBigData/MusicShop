using Microsoft.EntityFrameworkCore;
using Domain.Entity;
namespace Dal;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }


    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=1975;Database=musicShop");
    }*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.UseSerialColumns();
        /*modelBuilder.Entity<Factories>(entity =>
        {

        });*/
    }

    public DbSet<Factories> Factories { get; set; }
    public DbSet<Instruments> Instrument { get; set; }
    public DbSet<Warehouses> Warehouse { get; set; }
    public DbSet<Order_lines> Order_lines { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Services> Service { get; set; }
    public DbSet<Employees> Employee { get; set; }
    public DbSet<Customers> Customer { get; set; }

}

