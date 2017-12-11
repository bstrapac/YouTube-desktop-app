using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Configuration;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;


/*3.Kreirati projekt RESTapi tipa ClassLibrary unutar kojeg je potrebno definirati klasu REST koja ima metodu Search(). 
  Metoda pozivom rest api-ja vraća i parsira JSON u listu objekata klase YouTubeVideo.
  4.Kreirati klasu prema JSON strukturi odgovora */
namespace YouTube_kv
{
    public class REST
    {
        public List<YouTubeVideo> lYouTubeResults;
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";//Additional information: Specified value has invalid Control characters.
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<YouTubeVideo> GetVideos()
        {
            List<YouTubeVideo> lYTVideos = new List<YouTubeVideo>();
            string url = "https://www.googleapis.com/youtube/v3/search?part=snippet&q=kali&regionCode=HR&key=AIzaSyBRyYqGTzNh1xUlisww1zfif2ag3Wx9yms";
            string sJson = CallRestMethod(url);
            JArray oJson = JArray.Parse(sJson);
            //čitanje vrijednosti iz Json-a
            foreach (JObject item in oJson)
            {
                string Video_title = (string)item.GetValue("title");
                string Region_code = (string)item.GetValue("regionCode");
                string Video_id = (string)item.GetValue("videoID");
                string Channel_title = (string)item.GetValue("channelTitle");
                //dodavanje objekata u listu
                lYTVideos.Add(new YouTubeVideo
                {
                    sVideoTitle = Video_title,
                    sRegionCode = Region_code,
                    sVideoID = Video_id,
                    sChannelTitle = Channel_title,
                });
            }
            return lYTVideos;            
        }
    }
}
