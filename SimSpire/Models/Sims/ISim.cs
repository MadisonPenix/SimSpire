
using System.ComponentModel.Design.Serialization;

public interface ISim
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int Age { get; set; }
    string? ProfilePicture { get; set; }
    List<string> Notes { get; set; }

    public void KillSim();
    public void IncreaseAge();
    public void CelebrateBirthday();
    public void ChangeName(string firstName, string lastName);
    public void ChangeProfilePicture(string? imageURL);
    public void AddNote(string note);
    public void DeleteNote(string note);
    
}