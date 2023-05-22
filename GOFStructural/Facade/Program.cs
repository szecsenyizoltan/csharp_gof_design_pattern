using Newtonsoft.Json;
using System;
using System.Net;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = SimpleJsonConsumer<Movie>
                .DownloadAndConvertJson("https://nikprog.hu/samples/movie.json");
            
            

        }
    }
}
