using System.ComponentModel.DataAnnotations;

namespace SampleBrowser.Models
{
    public class SongModel
    {

        // Primary Key
        [Key] public int SongId { get; set; }
        

        // Song Fields
        public required int ArtistId { get; set; }

        public required ArtistModel Artist { get; set; }
        public required string Title { get; set; }
        public required string FilePath { get; set; }

        public required string Genre { get; set; }
        public required string Tags { get; set; } // Comma-separated custom tags (e.g., "happy,energetic")
    }
}
