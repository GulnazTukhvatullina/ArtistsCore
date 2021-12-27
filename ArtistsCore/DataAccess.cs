using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ArtistsCore
{
    public class DataAccess
    {
        public static List<Artist> GetArtist()
        {
            List<Artist> arts = new List<Artist>(bd_connections.connection.Artist.ToList());
            List<Artist> art = new List<Artist>();
            foreach (var type in arts)
            {
                art.Add(
                    new Artist
                    {
                        Surname = type.Surname,
                        Middle_name = type.Middle_name,
                        Name = type.Name
                    });
            }
            return arts;
        }

        public static List<Exhibition> GetExhibitions()
        {
            return new List<Exhibition>(bd_connections.connection.Exhibition);
        }

        public List<Hall> GetHalls()
        {
            return new List<Hall>(bd_connections.connection.Hall);
        }

        public List<Institution> GetInstitutions()
        {
            return new List<Institution>(bd_connections.connection.Institution);
        }

        public List<Institution_Hall> GetInstitution_Halls()
        {
            return new List<Institution_Hall>(bd_connections.connection.Institution_Hall);
        }

        public List<Painting_artist> GetPainting_Artists()
        {
            return new List<Painting_artist>(bd_connections.connection.Painting_artist);
        }

        public List<Type_exhibition> GetType_Exhibitions()
        {
            return new List<Type_exhibition>(bd_connections.connection.Type_exhibition);
        }
    }
}
