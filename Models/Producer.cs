using System.ComponentModel.DataAnnotations;

namespace EcommProject.Models
{
    public class Producer
    {

        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }


        //Relation (one producer has many movies)
        //One to many
        public List<Movie>Movies { get; set; }
    }
}
