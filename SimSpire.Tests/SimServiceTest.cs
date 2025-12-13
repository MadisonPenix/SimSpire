using Microsoft.EntityFrameworkCore;
using SimSpire.Models;
using SimSpire.Services.SimServiceLayer;
using Xunit;
using SimSpire.Test;
public class TestSimService : IClassFixture<TestDatabaseFixture>
    {
        public TestDatabaseFixture Fixture { get; }

        public TestSimService(TestDatabaseFixture fixture)
        {
            Fixture = fixture;
        }

        [Fact]
        public async Task GetSimByIdAsync_ExistingId_ReturnsSim()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var existingSim = new Sim { FirstName = "John", LastName = "Doe", Age = 30 };
            context.Sims.Add(existingSim);
            await context.SaveChangesAsync();

            // Act
            var result = await service.GetSimByIdAsync(existingSim.SimId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John", result.FirstName);
            Assert.Equal("Doe", result.LastName);
            Assert.Equal(30, result.Age);
        }

        [Fact]
        public async Task AddSimAsync_ValidSim_AddsSimToDatabase()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var newSim = new Sim { FirstName = "Jane", LastName = "Smith", Age = 28 };

            // Act
            await service.AddSimAsync(newSim);
            var addedSim = await context.Sims.FindAsync(newSim.SimId);

            // Assert
            Assert.NotNull(addedSim);
            Assert.Equal("Jane", addedSim.FirstName);
            Assert.Equal("Smith", addedSim.LastName);
            Assert.Equal(28, addedSim.Age);
        }  

        [Fact]
        public async Task UpdateFirstNameSimAsync_ExistingId_UpdatesSimInDatabase()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var simToUpdate = new Sim { FirstName = "Bob", LastName = "Pancakes", Age = 40 };
            context.Sims.Add(simToUpdate);
            await context.SaveChangesAsync();

            // Act
            simToUpdate.FirstName = "Robert";
            await service.UpdateFirstNameAsync(simToUpdate.SimId, simToUpdate.FirstName);
            var updatedSim = await context.Sims.FindAsync(simToUpdate.SimId);

            // Assert
            Assert.NotNull(updatedSim);
            Assert.Equal("Robert", updatedSim.FirstName);
            Assert.Equal("Pancakes", updatedSim.LastName);
            Assert.Equal(40, updatedSim.Age);
        }

        [Fact]
        public async Task UpdateLastNameSimAsync_ExistingId_UpdatesSimInDatabase()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var simToUpdate = new Sim { FirstName = "Charlie", LastName = "Davis", Age = 29 };
            context.Sims.Add(simToUpdate);
            await context.SaveChangesAsync();

            // Act
            simToUpdate.LastName = "Davidson";
            await service.UpdateLastNameAsync(simToUpdate.SimId, simToUpdate.LastName);
            var updatedSim = await context.Sims.FindAsync(simToUpdate.SimId);

            // Assert
            Assert.NotNull(updatedSim);
            Assert.Equal("Charlie", updatedSim.FirstName);
            Assert.Equal("Davidson", updatedSim.LastName);
            Assert.Equal(29, updatedSim.Age);
        }   

        [Fact]
        public async Task UpdateAgeSimAsync_ExistingId_UpdatesSimInDatabase()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var simToUpdate = new Sim { FirstName = "Diana", LastName = "Evans", Age = 32 };
            context.Sims.Add(simToUpdate);
            await context.SaveChangesAsync();

            // Act
            simToUpdate.Age = 33;
            await service.UpdateAgeAsync(simToUpdate.SimId, simToUpdate.Age);
            var updatedSim = await context.Sims.FindAsync(simToUpdate.SimId);

            // Assert
            Assert.NotNull(updatedSim);
            Assert.Equal("Diana", updatedSim.FirstName);
            Assert.Equal("Evans", updatedSim.LastName);
            Assert.Equal(33, updatedSim.Age);
        }   

        [Fact]
        public async Task DeleteSimAsync_ExistingId_DeletesSimFromDatabase()
        {
            // Arrange
            using var context = Fixture.CreateContext();
            var service = new SimServiceLayer(context);
            var simToDelete = new Sim { FirstName = "Alice", LastName = "Johnson", Age = 35 };
            context.Sims.Add(simToDelete);
            await context.SaveChangesAsync();

            // Act
            await service.DeleteSimAsync(simToDelete.SimId);
            var deletedSim = await context.Sims.FindAsync(simToDelete.SimId);

            // Assert
            Assert.Null(deletedSim);
        }   

    }