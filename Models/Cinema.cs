using System.ComponentModel.DataAnnotations;

namespace EcommProject.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }


        public string Logo { get; set; }

  
        public string Name { get; set; }

        public string Description { get; set; }

        //Relationship (A cinema has many movies)
        //One to Many relation
        public List<Movie> Movies { get; set; }



    }
}
