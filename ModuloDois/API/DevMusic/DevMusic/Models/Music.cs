namespace DevMusic.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
    }
}
