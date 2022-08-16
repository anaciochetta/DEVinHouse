using Microsoft.AspNetCore.Mvc;
using DevMusic.Repositories;
using DevMusic.Models;
using DevMusic.DTOs;

namespace DevMusic.Controllers
{
    [ApiController]
    [Route("api/artists")]
    public class ArtistsController : ControllerBase
    {
        //injetar o repositório para poder usar os métodos
        private ArtistRepository _artistRepository;

        public ArtistsController(ArtistRepository repository) //injeção pelo construtor
        {
            _artistRepository = repository;
        }

        [HttpPost]
        public ActionResult<Artist> Post(
            [FromBody] Artist newArtist
        )
        {
            _artistRepository.Create(newArtist);
            return Ok(newArtist);
        }

        //PUT api/artists/{id}
        [HttpPut("{artistId}")]
        public ActionResult<Artist> Put(
            [FromRoute] int artistId
        )
        {
            var artist = _artistRepository.GetById(artistId);
            _artistRepository.Update(artist);
            return artist;
        }

        [HttpPatch("{artistId}")]
        public ActionResult UpdatePhoto(
            [FromBody] ArtistPhotoDTO artistPhoto,
            [FromRoute] int artistId
        )
        {
            var updatedArtist = _artistRepository.UpdatePhoto(artistPhoto.UrlPhoto, artistId);
            return Ok(updatedArtist);

        }

        //Delete api/artists/{id}
        [HttpDelete("{artistId}")]
        public void Delete(
            [FromRoute] int artistId
        )
        {
            _artistRepository.Remove(artistId);
        }


        [HttpGet]
        public List<Artist> Get()
        {
            return _artistRepository.GetAll();
        }

        //GET api/artits?name=filter
        [HttpGet]
        public List<Artist> GetByName(
            [FromQuery] string filter
        )
        {
            return _artistRepository.GetByName(filter); ;
        }
    }
}