using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistsCore
{
    public static class ArtistStorage
    {
        public static List<Artist> art { get; private set; } = DataAccess.GetArtist();
    }
}
