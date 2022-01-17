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
                        ID_artist = type.ID_artist,
                        Surname = type.Surname,
                        Middle_name = type.Middle_name,
                        Name = type.Name,
                        Image = type.Image
                    });
            }
            return arts;
        }

        public static void AddArtist(Artist art)
        {
            try
            {
                bd_connections.connection.Artist.Add(art);
                bd_connections.connection.SaveChanges();
            }
            catch (Exception ex)
            {
                //Блок try-catch написан но ошибка не обрабатывается
            }
        }

        public static void DeleteArtist(Artist art) //Следует написать модуль try-catch
        {
            bd_connections.connection.Artist.Remove(art);
            bd_connections.connection.SaveChanges();
        }

        public static List<Painting_artist> GetPainting_Artists()
        {
            List<Painting_artist> paints = new List<Painting_artist>(bd_connections.connection.Painting_artist.ToList());
            List<Painting_artist> paint = new List<Painting_artist>();
            foreach (var type in paints)
            {
                paint.Add(
                    new Painting_artist
                    {
                        ID_painting_artist = type.ID_painting_artist,
                        Name = type.Name,
                        Image = type.Image
                    });
            }
            return paints;
        }

        //Хорошее решение
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

        public List<Type_exhibition> GetType_Exhibitions()
        {
            return new List<Type_exhibition>(bd_connections.connection.Type_exhibition);
        }
    }
}
