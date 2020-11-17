using album_collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Repositories
{
    public class ArtistRepository : Repository<Artist>, IRepository<Artist>
    {

        MusicContext db;

        public ArtistRepository(MusicContext context) : base(context)
        {
            db = context;
        }

        public override Artist GetById(int id)
        {
            return db.Artists.Where(o => o.Id == id).Include("Albums").FirstOrDefault();
        }

    }
}
