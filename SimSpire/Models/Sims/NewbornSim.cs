namespace SimSpire.Models
{
    public class Newborn : SimBase
    {

        //EF Core Compatible
        public Newborn()
        {
            Age = 0;
            LifeStage = LifeStages.Newborn;
        }

        //
        public Newborn(string first, string last, SimForm species, string? imageURL, LifeCycle? journey, List<Trait> traits, List<Relationship> relationships, List<Stat> stats, List<string> notes): 
            base(first, last, 0, LifeStages.Newborn, species, imageURL, journey, null, null, null, traits, relationships, stats, notes)
        {
            FirstName = first;
            LastName = last;
            Age = 0;
            LifeStage = LifeStages.Newborn;
            Species = species;
            ProfilePicture = imageURL;
            SoulsJourney = journey;
            Traits.AddRange(traits);
            Relationships.AddRange(relationships);
            Stats.AddRange(stats);
            Notes.AddRange(notes);
        }
    }
}