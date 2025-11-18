namespace SimSpire.Models
{
    public class Newborn : SimBase
    {

        //EF Core Compatible
        public Newborn()
        {
            Age = 0;
            
        }

        //
        public Newborn(string first, string last, string? imageURL, List<Stat> stats, List<string> notes): 
            base(first, last, 0, imageURL, stats, notes)
        {
            FirstName = first;
            LastName = last;
            Age = 0;
            ProfilePicture = imageURL;
            Stats.AddRange(stats);
            Notes.AddRange(notes);
        }
    }
}