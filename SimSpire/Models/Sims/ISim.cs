
using System.ComponentModel.Design.Serialization;

public interface ISim
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int Age { get; set; }

    LifeStages LifeStage { get; set; }
    SimForm Species { get; set; }
    string? ProfilePicture { get; set; }
    LifeCycle SoulsJourney { get; set; }
    List<Trait> Traits { get; set; }
    List<Relationship> Relationships { get; set; }
    List<Stat> Stats { get; set; }
    List<string> Notes { get; set; }

    public static void CreateSim(string name, int age, SimForm species, string? profPic, LifeCycle? journey, List<Trait> traits, List<Relationship> relationships, List<Stat> stats, List<string>? notes);
    public void KillSim();
    public void IncreaseAge();
    public void CelebrateBirthday();
    public void ChangeName(string newName);
    public void ChangeSimForm(SimForm newForm);
    public void ChangeProfilePicture(string? imageURL);
    public void UpdateSoulsJourney();
    public void AddNewTrait(Trait trait);
    public void DeleteTrait(Trait trait);
    public void UpdateRelationships(Relationship relationship);
    public void AddStat(Stat stats);
    public void AddNote(string note);
    public void DeleteNote(string note);
    
}