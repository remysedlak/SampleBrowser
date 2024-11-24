using System.ComponentModel.DataAnnotations;

namespace SampleBrowser.Models
{
    public class ArtistModel
    {
        // Primary Key
        [Key] public int ArtistId { get; set; }

        public required string Name { get; set; }
        public required string Genre { get; set; }

        public required ICollection<SongModel> Songs { get; set; } // Navigation property for related songs




    }
}
