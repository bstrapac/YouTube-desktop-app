using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

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
                            nVideoID = (int)oReader["Video_Id"],
                            sVideoTitle = (string)oReader["Video_Naziv"],
                            sVideoLink = (string)oReader["Video_Link"],
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
            {
                string sQuery = "INSERT INTO YouTube_videos (Video_Naziv, Video_Link, Video_Channel, Video_Description) VALUES ('" + oVideo.sVideoTitle + "', '" + oVideo.sVideoLink + "', '" + oVideo.sChannelTitle + "', '" + oVideo.sDescription + "');";
                oCommand.CommandText = sQuery;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void DeleteVideo(YouTubeVideo oVideo)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["SqlConnectionString"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM YouTube_videos WHERE Video_Id = '" + oVideo.nVideoID + "';";
           
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    
                }
            }
        }
    }
}
