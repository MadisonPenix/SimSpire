using Microsoft.EntityFrameworkCore;
using SimSpire.Models;

public class SimContext : DbContext
{
    //entities
    public DbSet<Sim> Sims {get; set;}

    public SimContext(DbContextOptions<SimContext> options)
            : base(options)
        {
        }

    //Specify a connection string for the database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Hardcoded for now - will move later
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SimDb;Trusted_Connection=True;");
    }
}
