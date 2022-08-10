using DevMusic.Models;

namespace DevMusic.Repositories;

public class ArtistRepository
{
    private static int _indexId = 1;
    private static List<Artist> _artists = new();

    //cria o artista, coloca id e adciona na lista de artistas
    public Artist Create(Artist artist)
    {
        artist.Id = _indexId;
        _indexId++;

        _artists.Add(artist);

        return artist;
    }
    public Artist Update(Artist artist)
    {
        var currentArtist = GetArtistById(artist.Id);

        currentArtist.Name = artist.Name;
        currentArtist.ArtisticName = artist.ArtisticName;
        currentArtist.UrlPhoto = artist.UrlPhoto;
        currentArtist.Country = artist.Country;

        return currentArtist;
    }
    public Artist UpdatePhoto(string artistPhoto, int id)
    {
        var currentArtist = GetArtistById(id);

        currentArtist.UrlPhoto = artistPhoto;

        return currentArtist;
    }
    public void Remove(int id)
    {
        var currentArtist = GetArtistById(id);
        _artists.Remove(currentArtist);
    }
    public List<Artist> GetAll()
    {
        return _artists;
    }
    public Artist GetArtistById(int id)
    {
        return _artists.FirstOrDefault(list => list.Id == id);
    }
    public List<Artist> GetArtistByName(string name)
    {
        return _artists.Where(list => list.Name == name || list.ArtisticName == name).ToList();
    }

}
