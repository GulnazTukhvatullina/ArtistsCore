using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistsCore
{
    //Не следует испольовать статический класс
    public static class ArtistStorage
    {
        public static List<Artist> art { get; private set; } = DataAccess.GetArtist();

        public static void Add(Artist artist)
        {
            DataAccess.AddArtist(artist);
            art.Add(artist);
        }

        public static void RemoveByName(int id)
        {
            art.RemoveAll(p => p.ID_artist == id);
        }
    }

    
}
