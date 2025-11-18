using System.ComponentModel.DataAnnotations;

namespace SimSpire.Models
{
    public abstract class SimBase : ISim
    {
        [Key] int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public string? ProfilePicture { get; set; }
        public List<Trait> Traits { get; set; } = new List<Trait>();
        public List<Relationship> Relationships { get; set; } = new List<Relationship>();
        public List<Stat> Stats { get; set; } = new List<Stat>();
        public List<string> Notes { get; set; } = new List<string>();
        
        protected SimBase() { } //For EF Core
        protected SimBase(string first, string last, int age, string? imageURL,  List<Relationship> relationships, List<Stat> stats, List<string> notes)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            ProfilePicture = imageURL;
            Relationships.AddRange(relationships);
            Stats.AddRange(stats);
            Notes.AddRange(notes);
        }
        public void KillSim()
        {
            // Add to Cemetary

        }
        
        public void IncreaseAge()
        {
            Age++;
        }
    public void CelebrateBirthday()
        {
            IncreaseAge();
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

    public void UpdateRelationships(Relationship relationship)
        {
            //Relationship.UpdateRelationship();
        }
    public void AddStat(Stat stats)
        {
            //Stat.AddStat();
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