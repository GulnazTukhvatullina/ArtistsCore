using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistsCore
{
    class PaintArtStorage
    {
        public static List<Painting_artist> paint { get; private set; } = DataAccess.GetPainting_Artists();
    }
}
