using System;
using System.Collections.Generic;
using ArtistsCore;

namespace ArtistsConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                string values = Console.ReadLine();
                Artist(command, values);
            }

        }
        private static void Artist(string command, string values)
        {
            string[] value = values.Split(' ');
            switch(command)
            {
                case "Get artist":
                    List<Users> art = DataAccess.GetArtist();
                    foreach (Users i in art)
                    {
                        if (i.ID_role == 2)
                        {
                            Console.WriteLine($"{i.ID_user}, {i.Surname} {i.Name} ");
                            Console.WriteLine("Дата рождения:" + $"{i.Information_artist.Birth_date}");
                            Console.WriteLine("Краткая биография:" + $"{i.Information_artist.Biography}");
                        }
                    }
                    break;

                case "Get paint":
                    List<Painting_artist> paint = DataAccess.GetPaint();
                    foreach (Painting_artist i in paint)
                    {
                        Console.WriteLine($"{i.ID_painting_artist}, {i.Name}");
                        Console.WriteLine($"{i.Creation_date}");
                        Console.WriteLine($"{ i.Execution}");
                    }
                    break;

                case "Get exhibition":
                    List<Exhibition> exhibition = DataAccess.GetExhibitions();
                    foreach (Exhibition i in exhibition)
                    {
                        Console.WriteLine($"{i.ID_exhibition}, {i.Name}");
                        Console.WriteLine($"{i.Users.Surname}");
                        Console.WriteLine($"{i.Date}");
                        Console.WriteLine($"{ i.Information}");
                    }
                    break;
            }
        }
    }
}
