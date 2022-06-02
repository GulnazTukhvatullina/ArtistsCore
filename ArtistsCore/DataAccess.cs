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
        public static List<Users> GetArtist()
        {
            List<Users> arts = new List<Users>(bd_connections.connection.Users.ToList());
            List<Users> art = new List<Users>();
            foreach (var type in arts)
            {
                art.Add(
                    new Users
                    {
                        ID_user = type.ID_user,
                        Surname = type.Surname,
                        Name = type.Name,
                        ID_role = type.ID_role
                    });
            }
            return arts;
        }

        public static List<Painting_artist> GetPaint()
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
                        ID_user = type.ID_user,
                        Creation_date = type.Creation_date,
                        Execution = type.Execution
                    });
            }
            return paints;
        }

        public static List<Exhibition> GetExhibitions()
        {
            List<Exhibition> exhibitions = new List<Exhibition>(bd_connections.connection.Exhibition.ToList());
            List<Exhibition> exhibition = new List<Exhibition>();
            foreach (var type in exhibitions)
            {
                exhibition.Add(
                    new Exhibition
                    {
                        ID_exhibition = type.ID_exhibition,
                        Name = type.Name,
                        ID_user = type.ID_user,
                        Date = type.Date,
                        Information = type.Information
                    });
            }
            return exhibitions;
        }
    }
}
