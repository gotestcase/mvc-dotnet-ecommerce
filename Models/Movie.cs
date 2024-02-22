using EcommProject.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommProject.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Category { get; set; }

        //Relationships (many to many) -> Define a join table
        //Many actors
        public List<Actor_Movie> Actors_Movies { get; set; }
        


        //Cinema (linked to one cinema)
        //Many to One
        //Define the fk to Cinema
        public int CinemaId {  get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        //Producer (linked to one producer)
        //Many to One
        //Define the fk to producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
