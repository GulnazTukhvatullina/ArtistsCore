using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ArtistsCore
{
    class DataAccess
    {
        public static ArtistEntities connection = new ArtistEntities();

        public List<Artist> GetArtist()
        {
            return new List<Artist>(connection.Artist);
        }

        public List<Exhibition> GetExhibitions()
        {
            return new List<Exhibition>(connection.Exhibition);
        }

        public List<Hall> GetHalls()
        {
            return new List<Hall>(connection.Hall);
        }

        public List<Institution> GetInstitutions()
        {
            return new List<Institution>(connection.Institution);
        }

        public List<Institution_Hall> GetInstitution_Halls()
        {
            return new List<Institution_Hall>(connection.Institution_Hall);
        }

        public List<Painting_artist> GetPainting_Artists()
        {
            return new List<Painting_artist>(connection.Painting_artist);
        }

        public List<Type_exhibition> GetType_Exhibitions()
        {
            return new List<Type_exhibition>(connection.Type_exhibition);
        }
    }
}
