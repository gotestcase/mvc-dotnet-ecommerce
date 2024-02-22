namespace EcommProject.Models
{
    public class ActorsViewModel
    {
        public ActorsViewModel()
        {
            Actors = new List<Actor>();
        }

        public List<Actor> Actors { get; set; }
    }
}
