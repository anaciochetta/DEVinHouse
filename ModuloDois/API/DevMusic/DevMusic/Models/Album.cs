namespace DevMusic.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        //compositor/artista que fez o álbum
        public Artist Artist { get; set; }
        //gênero musical
        public string Genre { get; set; }
    }
}
