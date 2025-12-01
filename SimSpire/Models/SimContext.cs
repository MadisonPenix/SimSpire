using Microsoft.EntityFrameworkCore;
using SimSpire.Models;

public class SimContext : DbContext
{
    //entities
    public DbSet<Sim> Sims {get; set;}

    //Specify a connection string for the database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SimDb;Trusted_Connection=True;");
    }
}
