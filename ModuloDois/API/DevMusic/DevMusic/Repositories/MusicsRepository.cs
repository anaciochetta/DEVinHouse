using DevMusic.Models;

namespace DevMusic.Repositories;

public class MusicsRepository
{
    private static int _indexId = 1;
    private static List<Music> _musics = new();

    //GET
    public List<Music> GetAll()
    {
        return _musics;
    }
    public Music GetById(int id)
    {
        return _musics.FirstOrDefault(list => list.Id == id);
    }

    public List<Music> GetByName(string name)
    {
        return _musics.Where(list => list.Name == name).ToList();
    }

    /* public List<Music> GetByAlbum(string album)
    {
        return _musics.Where(list => list.Album == album).ToList();
    }

    public List<Music> GetByArtist(string artist)
    {
        return _musics.Where(list => list.Artist == artist).ToList();
    } */

    //PUT
    public Music Create(Music music)
    {
        music.Id = _indexId;
        _indexId++;

        _musics.Add(music);

        return music;
    }

    //PUT
    public Music Update(Music music)
    {
        var currentMusic = GetById(music.Id);

        currentMusic.Name = music.Name;
        currentMusic.Duration = music.Duration;
        currentMusic.Album = music.Album;
        currentMusic.Artist = music.Artist;

        return currentMusic;
    }

    //DELETE
    public void Remove(int id)
    {
        var currentMusic = GetById(id);
        _musics.Remove(currentMusic);
    }
}
