using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LibraryManagement.Areas.Identity.Data;
namespace LibraryManagement
{
    public class Book:BookContext
    {
        public int Id { get; set; }
        [Required, JsonPropertyName("Name")]
        public string? Title1 { get; set; }

        [Required ]
        public string? Author { get; set; }
        public string? Description { get; set; }

        [EnglishOnly]
        public string? Language {  get; set; }

        [NoHorrorTwo]
        public BookGenre Genre { get; set; }
        public DateOnly PublicationDate { get; set; }

        public enum BookGenre
        {
            Fantasy,
            ScienceFiction,
            Mystery,
            Romance,
            Horror
        }

        public override string ToString()
        {
            return $"Book successfully created \n Id: {Id} \n Title: {Title1} \n Description: {Description} \n Author: {Author} \n Genre: {Genre} \n Published On: {PublicationDate}";
        }

    }
}
