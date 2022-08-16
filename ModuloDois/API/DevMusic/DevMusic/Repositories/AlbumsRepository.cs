using DevMusic.Models;

namespace DevMusic.Repositories;

public class AlbumsRepository
{
    private static int _indexId = 1;
    private static List<Album> _albums = new();

    //GET
    public List<Album> GetAll()
    {
        return _albums;
    }
    public Album GetById(int id)
    {
        return _albums.FirstOrDefault(list => list.Id == id);
    }

    //PUT
    public Album Create(Album album)
    {
        album.Id = _indexId;
        _indexId++;

        _albums.Add(album);

        return album;
    }

    //PUT
    public Album Update(Album album)
    {
        var currentAlbum = GetById(album.Id);

        currentAlbum.Name = album.Name;
        currentAlbum.ReleaseYear = album.ReleaseYear;
        currentAlbum.Artist = album.Artist;
        currentAlbum.Genre = album.Genre;

        return currentAlbum;
    }

    //DELETE
    public void Remove(int id)
    {
        var currentAlbum = GetById(id);
        _albums.Remove(currentAlbum);
    }
}
