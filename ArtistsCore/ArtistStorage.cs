using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistsCore
{
    public static class ArtistStorage
    {
        public static List<Users> art { get; private set; } = DataAccess.GetArtist();

        public static void RemoveByName(int id)
        {
            art.RemoveAll(p => p.ID_user == id);
        }
    }

    
}
