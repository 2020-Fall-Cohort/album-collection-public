using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using album_collection.Models;
using album_collection.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        // GET: api/<AlbumController>
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumRepo.GetAll();
        }

        // GET api/<AlbumController>/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumRepo.GetById(id);
        }

        // POST api/<AlbumController>
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album album)
        {
            albumRepo.Create(album);
            return albumRepo.GetAll();
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public IEnumerable<Album> Put(int id, [FromBody] Album album)
        {
            albumRepo.Update(album);
            return albumRepo.GetAll();
        }

        // DELETE api/<AlbumController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            var album = albumRepo.GetById(id);
            albumRepo.Delete(album);
            return albumRepo.GetAll();
        }
    }
}
