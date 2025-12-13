using SimSpire.Models;
namespace SimSpire.Services.SimServiceLayer
{
    public interface ISimService
    {
        Task<Sim?> GetSimByIdAsync(int id);
        Task AddSimAsync(Sim sim);
        Task UpdateFirstNameAsync(int id, string newFirstName);
        Task UpdateLastNameAsync(int id, string newLastName);
        Task UpdateAgeAsync(int id, int newAge);
        Task UpdateProfilePictureAsync(int id, string? newProfilePicture);
        Task DeleteSimAsync(int id);
    }

    
}