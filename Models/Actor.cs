using System.ComponentModel.DataAnnotations;
namespace EcommProject.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }
   
        public string Fullname { get; set; }

       
        public string Bio { get; set; }


        //Relationship (link it to the table Actor_Movie)
        public List<Actor_Movie>Actors_Movies { get; set; }
    }
}
