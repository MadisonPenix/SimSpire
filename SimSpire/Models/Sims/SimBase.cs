using System.ComponentModel.DataAnnotations;

namespace SimSpire.Models
{
    public abstract class SimBase : ISim
    {
        [Key] int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public LifeStages LifeStage { get; set; }
        public SimForm Species { get; set; }
        public string? ProfilePicture { get; set; }
        public LifeCycle SoulsJourney { get; set; }
        public List<Trait> Traits { get; set; } = new List<Trait>();
        public List<Relationship> Relationships { get; set; } = new List<Relationship>();
        public List<Stat> Stats { get; set; } = new List<Stat>();
        public List<string> Notes { get; set; } = new List<string>();
        
        protected SimBase() { } //For EF Core
        protected SimBase(string first, string last, int age, SimForm species, LifeStages lifeStage, string? imageURL, LifeCycle? journey, List<Trait> traits, List<Relationship> relationships, List<Stat> stats, List<string> notes)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            LifeStage = lifeStage;
            Species = species;
            ProfilePicture = imageURL;
            SoulsJourney = journey;
            Traits.AddRange(traits);
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
    public void ChangeSimForm(SimForm newForm)
        {
            Species = newForm;
        }
    public void ChangeProfilePicture(string? imageURL)
        {
            ProfilePicture = imageURL;
        }
    public void UpdateSoulsJourney()
        {
            //SoulsJourney.Update();
        }
    public void AddNewTrait(Trait trait)
        {
            //Trait.AddNewTrait();
        }
    public void DeleteTrait(Trait trait)
        {
            //Trait.DeleteTrait();
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