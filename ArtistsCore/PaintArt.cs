using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistsCore
{
    //Критический : класс внутри класса
    class PaintArt
    {
        public class MyPainting_artist
        {
            public string ID_painting_artist { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
        }
    }
}
