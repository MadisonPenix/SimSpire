using System.ComponentModel.DataAnnotations;

namespace SimSpire.Models
{
    public class Sim
    {
        public int SimId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? ProfilePicture { get; set; }
      
        public Sim()
        {
            
        }
        public void KillSim()
        {
            // Add to Cemetary

        }
        
        public void ChangeAge(int age)
        {
            Age = age;
        }
    public void CelebrateBirthday()
        {
            //LifeStages.CelebrateBirthday();
        }
    public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    public void ChangeProfilePicture(string? imageURL)
        {
            ProfilePicture = imageURL;
        }

    public void AddNote(string note)
        {
            //Note.AddNote();
        }
    public void DeleteNote(string note)
        {
            //Note.DeleteNote();
        }

    }


}