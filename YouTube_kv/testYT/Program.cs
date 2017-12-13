using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTube_kv;

namespace testYT
{
    class Program
    {
        static void Main(string[] args)
        {
            REST Video = new REST();
            List < YouTubeVideo> list = Video.GetVideos();
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i].sVideoTitle + ' ' + list[i].sVideoID);
            }
            Console.ReadLine();


        }
    }
}
