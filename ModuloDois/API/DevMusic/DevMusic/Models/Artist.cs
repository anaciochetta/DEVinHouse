using System.ComponentModel.DataAnnotations;

namespace DevMusic.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do artista é obrigatório.")]
        public string Name { get; set; }
        public string ArtisticName { get; set; }
        public string UrlPhoto { get; set; }
        public string Country { get; set; }
    }
}
