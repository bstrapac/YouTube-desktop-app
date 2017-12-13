﻿using System;
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
using Newtonsoft.Json;
using System.Diagnostics;


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
            string url = "";
            string sJson = CallRestMethod(url);
            JObject oJson = JObject.Parse(sJson);
            var oVideos = oJson["items"].ToList();//doći do snippet čvora 
            for(int i=0;i<oVideos.Count();i++)
            {
                lYTVideos.Add(new YouTubeVideo
                {
                    sVideoID = (string)oVideos[i]["videoID"],
                    sVideoTitle = (string)oVideos[i]["title"],
                    sDescription = (string)oVideos[i]["description"],
                    sChannelTitle = (string)oVideos[i]["channelTitle"],
                });
            }
            return lYTVideos;     
        }
    }
}
