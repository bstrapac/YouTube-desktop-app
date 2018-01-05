using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace YouTube_kv
{
    public class CRUD
    {
        public List<YouTubeVideo> GetVideosDB()
        {
            List<YouTubeVideo> lVideos = new List<YouTubeVideo>();
            string sSqlConnectionString = ConfigurationManager.AppSettings["SqlConnectionString"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM YouTube_videos";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lVideos.Add(new YouTubeVideo()
                        {
                            sVideoTitle = (string)oReader["Video_Naziv"],
                            sVideoID = (string)oReader["Video_Link"],
                            sChannelTitle = (string)oReader["Video_Channel"],
                            sDescription = (string)oReader["Video_Description"],
                        });
                    }
                }
            }
            return lVideos;
        }
        public void SaveVideo(YouTubeVideo oVideo)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["SqlConnectionString"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            //using- pozivanjem ove naredbe iskorištena memorija nakon korištenja se oslobađa
            {
                oCommand.CommandText = "INSERT INTO YouTube_videos (Video_Naziv, Video_Link, Video_Channel, Video_Description) VALUES ('" + oVideo.sVideoTitle + "', '" + oVideo.sVideoID + "', ' " + oVideo.sChannelTitle + "', '" + oVideo.sDescription+"');";
                //kombinacija stringa sa varijablama kako bi smo popunili sql naredbe za promjene u bazi podataka (za string '' u sql)
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    //nema povratne vrijednosti
                }
            }
        }
    }
}
