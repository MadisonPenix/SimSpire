using Microsoft.EntityFrameworkCore;
using SimSpire.Models;
using SimSpire.Services.SimServiceLayer;
using Xunit;

namespace SimSpire.Test
{
    public class TestDatabaseFixture
    {

        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=EFTestSample;Trusted_Connection=True;ConnectRetryCount=0";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            // Ensure database is initialized only once and not run tests in parallel
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        // Ensure database is deleted from previous test runs and recreated
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                    }

                    // Mark database as initialized
                    _databaseInitialized = true;
                }
            }
        }

        // Creates a new instance of the DbContext for testing.
        public SimContext CreateContext()
            => new SimContext(
                new DbContextOptionsBuilder<SimContext>()
                    .UseSqlServer(ConnectionString)
                    .Options);

    }
}