using Microsoft.AspNetCore.Mvc;
using DevMusic.Repositories;
using DevMusic.Models;

namespace DevMusic.Controllers;

[ApiController]
[Route("api/album")]
public class AlbumsController : ControllerBase
{
    private AlbumsRepository _albumRepository;
    public AlbumsController(AlbumsRepository repository)
    {
        _albumRepository = repository;
    }

    [HttpPost]
    public ActionResult<Album> Post(
        [FromBody] Album newAlbum
    )
    {
        _albumRepository.Create(newAlbum);
        return Ok(newAlbum);
    }

    [HttpPut("{albumId}")]
    public ActionResult<Album> Put(
        [FromRoute] int albumId
    )
    {
        Album album = _albumRepository.GetById(albumId);
        _albumRepository.Update(album);
        return album;
    }

    [HttpDelete("{albumId}")]
    public void Delete(
            [FromRoute] int albumId
        )
    {
        _albumRepository.Remove(albumId);
    }

    [HttpGet]
    public List<Album> Get()
    {
        return _albumRepository.GetAll();
    }
}
