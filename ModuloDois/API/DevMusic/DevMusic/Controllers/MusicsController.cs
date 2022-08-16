using Microsoft.AspNetCore.Mvc;
using DevMusic.Repositories;
using DevMusic.Models;

namespace DevMusic.Controllers;

[ApiController]
[Route("api/musics")]
public class MusicsController : ControllerBase
{
    private MusicsRepository _musicRepository;
    public MusicsController(MusicsRepository repository)
    {
        _musicRepository = repository;
    }

    [HttpPost]
    public ActionResult<Music> Post(
        [FromBody] Music newMusic
    )
    {
        _musicRepository.Create(newMusic);
        return Ok(newMusic);
    }

    [HttpPut("{musicId}")]
    public ActionResult<Music> Put(
        [FromRoute] int musicId
    )
    {
        Music music = _musicRepository.GetById(musicId);
        _musicRepository.Update(music);
        return music;
    }

    [HttpDelete("{musicId}")]
    public void Delete(
            [FromRoute] int musicId
        )
    {
        _musicRepository.Remove(musicId);
    }

    [HttpGet]
    public List<Music> Get()
    {
        return _musicRepository.GetAll();
    }

    [HttpGet]
    public List<Music> GetByName(
           [FromQuery] string filter
       )
    {
        return _musicRepository.GetByName(filter); ;
    }
}