using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouTube_kv;
using System.Diagnostics;
using System.Windows;
using System.Net;
using System.IO;

namespace WindowsFormsYouToubeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataGridView pretraženih videa
            DataGridViewImageColumn oSaveButton = new DataGridViewImageColumn();
            oSaveButton.Image = Image.FromFile("D:/YouTube_KV/save.png");
            oSaveButton.Width = 50;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridYT.Columns.Add(oSaveButton);
            dataGridYT.AutoGenerateColumns = false;
            dataGridYT.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridYT.Rows.Add(Environment.NewLine);
            dataGridYT.RowTemplate.MinimumHeight = 30;

            //DataGridView videa iz baze podataka
            CRUD rVideo = new CRUD();
            List<YouTubeVideo> list1 = rVideo.GetVideosDB();
            dgMojiVidei.DataSource = list1;
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            DataGridViewImageColumn oPlayButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/YouTube_KV/basket.png");
            oPlayButton.Image = Image.FromFile("D:/YouTube_KV/play.png");
            oDeleteButton.Width = 50;
            oPlayButton.Width = 50;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            oPlayButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgMojiVidei.Columns.Add(oDeleteButton);
            dgMojiVidei.Columns.Add(oPlayButton);
            dgMojiVidei.AutoGenerateColumns = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            REST Video = new REST();
            CRUD SpremljeniYT = new CRUD();
            List<YouTubeVideo> list = Video.GetVideos(inptPretraziYT.Text);
            List<YouTubeVideo> Spremljeni = SpremljeniYT.GetVideosDB();
            dataGridYT.DataSource = list;
            for (int j = 0; j < Spremljeni.Count(); j++)
            {
                string comparison = Spremljeni[j].sVideoLink;
                foreach (DataGridViewRow dgRow in dataGridYT.Rows)
                {
                    var cell = dgRow.Cells[3];
                    if (cell.Value.ToString() == comparison)
                    {
                        dgRow.DefaultCellStyle.BackColor = Color.Red;
                        dgRow.Cells[5].Value = Image.FromFile("D:/YouTube_KV/check.png");
                    }
                }
                dataGridYT.DataSource = list;                
                dataGridYT.Show();
            }
        }
        private void dgMojiVidei_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {                
            if (dgMojiVidei.Columns[e.ColumnIndex].Name == "Thumbnail")
            {
                e.Value = GetImageFromUrl("https://i.ytimg.com/vi/6lBadPs5iK0/default.jpg");               
            }
        }

        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void dataGridYT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUD SaveVideoYT = new CRUD();
            CRUD Videi = new CRUD();
            List<YouTubeVideo> Spremljeni = Videi.GetVideosDB();
            dataGridYT.Rows[e.RowIndex].Selected = true;
            if (dataGridYT.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                string Thumbnail = dataGridYT.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Title = dataGridYT.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ChannelTitle = dataGridYT.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Link = dataGridYT.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Opis = dataGridYT.Rows[e.RowIndex].Cells[4].Value.ToString();
                string Description = Opis.Replace("'", "");
                string Naslov = Title.Replace("'", "");
                string Kanal = ChannelTitle.Replace("'", "");
                YouTubeVideo oVideo = new YouTubeVideo()
                {
                    sVideoTitle = Naslov,
                    sVideoLink = Link,
                    sChannelTitle = Kanal,
                    sDescription = Description,
                    sVideoImage = Thumbnail,
                };
                SaveVideoYT.SaveVideo(oVideo);
                MessageBox.Show("Uspješno ste spremili video!");

                dgMojiVidei.DataSource = Videi.GetVideosDB();
            }
        }

    private void dgMojiVidei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUD DeleteVideoYT = new CRUD();
            dgMojiVidei.Rows[e.RowIndex].Selected = true;
            if (dgMojiVidei.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                string ID = dgMojiVidei.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Image = dgMojiVidei.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Naziv = dgMojiVidei.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Kanal = dgMojiVidei.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Opis = dgMojiVidei.Rows[e.RowIndex].Cells[4].Value.ToString();
                string Link = dgMojiVidei.Rows[e.RowIndex].Cells[5].Value.ToString();
                YouTubeVideo oVideo = new YouTubeVideo()
                {
                    nVideoID = Int32.Parse(ID),
                    sVideoTitle = Naziv,
                    sVideoLink = Link,
                    sChannelTitle = Kanal,
                    sDescription = Opis,
                    sVideoImage = Image,
                };
                DeleteVideoYT.DeleteVideo(oVideo);
                CRUD cVidei = new CRUD();
                dgMojiVidei.DataSource = cVidei.GetVideosDB();
            }
            if (dgMojiVidei.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                string sLink = dgMojiVidei.Rows[e.RowIndex].Cells[4].Value.ToString();
                string address = "https://www.youtube.com/watch?v=";
                address += sLink;
                playVideo.Navigate(address);
                Debug.WriteLine(address);
                playVideo.Show();
            }
        }
    }
}
