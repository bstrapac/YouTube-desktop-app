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
            List<YouTubeVideo> videi = Video.GetVideos();
            for (int i = 0; i < videi.Count; i++)
            {
                Console.WriteLine(videi[i].sVideoTitle + "/n " + videi[i].sChannelTitle);
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadLine();


        }
    }
}
