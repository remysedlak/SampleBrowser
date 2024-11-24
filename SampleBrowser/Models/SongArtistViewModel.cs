using System.ComponentModel.DataAnnotations;

namespace SampleBrowser.Models
{
    public class SongArtistViewModel
    {
        public required string SongTitle { get; set; }
        public required IFormFile SongFile { get; set; }
        public required string ArtistName { get; set; }
    }
}
