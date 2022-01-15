using System;
using System.Collections.Generic;
using ArtistsCore;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                string values = Console.ReadLine();
                PrintArtist(command, values);
            }

        }
        private static void PrintArtist(string command, string values)
        {
            string[] value = values.Split(',');
            switch(command)
            {
                case "Get":
                    List<Artist> art = DataAccess.GetArtist();
                    foreach (Artist i in art)
                    {
                        Console.WriteLine($"{i.ID_artist}, {i.Surname}, {i.Name}, {i.Middle_name}, {i.Birth_date}, {i.Date_death}, {i.Country}");
                    }
                    break;
                case "Add":
                    DataAccess.AddArtist(new Artist()
                    {
                        ID_artist = Convert.ToInt32(value[0]),
                        Surname = value[1],
                        Name = value[2],
                        Middle_name = value[3],
                        Birth_date = Convert.ToDateTime(value[4]),
                        Date_death = Convert.ToDateTime(value[5]),
                        Country = value[6]
                    });
                    break;
                case "Remove":
                    DataAccess.DeleteArtist(new Artist()
                    {
                        ID_artist = Convert.ToInt32(value[0]),
                        Surname = value[1],
                        Name = value[2],
                        Middle_name = value[3],
                        Birth_date = Convert.ToDateTime(value[4]),
                        Date_death = Convert.ToDateTime(value[5]),
                        Country = value[6]
                    });
                    break;
            }
        }
    }
}
