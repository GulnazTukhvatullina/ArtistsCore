using System;
using ArtistsCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var da = new DataAccess();
            var bp = da.GetHalls();
            Console.WriteLine(bp[0].Name);
        }
    }
}
