using album_collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {

        MusicContext db;

        public AlbumRepository(MusicContext context) : base(context)
        {
            db = context;
        }

        public override IEnumerable<Album> GetAll()
        {
            return db.Albums.Include("Artist").ToList();
        }
    }
}
