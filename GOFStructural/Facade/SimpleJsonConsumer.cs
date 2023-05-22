using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal static class SimpleJsonConsumer<T>
    {
        public static T[] DownloadAndConvertJson(string url)
        {
            //1. letöltés
            WebClient wc = new WebClient();
            string result = wc.DownloadString("https://nikprog.hu/samples/movie.json");

            //2. átalakítás
            T[] items = JsonConvert.DeserializeObject<T[]>(result);

            return items;
        }
    }
}
