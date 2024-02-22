namespace EcommProject.Models
{

    // this is the table for the relationships
    //Many to Many relationship
    public class Actor_Movie
    {
        //foreign key for the movie model
        public int MovieId { get; set; } // col of the table
        public Movie Movie { get; set; } // Define the relationship
       
        //foreign key for the actor model
        public int ActorId { get; set; } // col of the table
        public Actor Actor { get; set; } //Define relationship with this entity
    }
}
