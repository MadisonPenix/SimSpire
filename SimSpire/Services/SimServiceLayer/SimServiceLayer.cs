using SimSpire.Models;
using SimSpire.Services.SimServiceLayer;

namespace SimSpire.Services.SimServiceLayer{
    public class SimServiceLayer : ISimService
    {
        private readonly SimContext _context;

        public SimServiceLayer(SimContext context)
        {
            _context = context;
        }

        public async Task<Sim?> GetSimByIdAsync(int id)
        {
            return await _context.Sims.FindAsync(id);
        }

        public async Task AddSimAsync(Sim sim)
        {
            _context.Sims.Add(sim);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFirstNameAsync(int id, string newFirstName)
        {
            var sim = await _context.Sims.FindAsync(id);
            if (sim != null){ return; }
            sim.FirstName = newFirstName;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLastNameAsync(int id, string newLastName)
        {
            var sim = await _context.Sims.FindAsync(id);
            if (sim != null){ return; }
            sim.LastName = newLastName;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAgeAsync(int id, int newAge)
        {
            var sim = await _context.Sims.FindAsync(id);
            if (sim != null){ return; }
            sim.Age = newAge;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProfilePictureAsync(int id, string? newProfilePicture)
        {
            var sim = await _context.Sims.FindAsync(id);
            if (sim != null){ return; }
            sim.ProfilePicture = newProfilePicture;
            await _context.SaveChangesAsync();
        }
      

        public async Task DeleteSimAsync(int id)
        {
            var sim = await _context.Sims.FindAsync(id);
            if (sim != null)
            {
                _context.Sims.Remove(sim);
                await _context.SaveChangesAsync();
            }
        }

    }
}
