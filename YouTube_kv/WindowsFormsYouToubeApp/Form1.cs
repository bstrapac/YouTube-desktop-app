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

namespace WindowsFormsYouToubeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
            DataGridViewImageColumn oSaveButton = new DataGridViewImageColumn();
            oSaveButton.Image = Image.FromFile("D:/YouTube_KV/check.png");
            oSaveButton.Width = 40;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridYT.Columns.Add(oSaveButton);
            dataGridYT.AutoGenerateColumns = false;


            CRUD rVideo = new CRUD();
            List<YouTubeVideo> list1 = rVideo.GetVideosDB();
            dgMojiVidei.DataSource = list1;
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/YouTube_KV/basket.png");
            oDeleteButton.Width = 40;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgMojiVidei.Columns.Add(oDeleteButton);
            dgMojiVidei.AutoGenerateColumns = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            REST Video = new REST();
            List<YouTubeVideo> list = Video.GetVideos(inptPretraziYT.Text);
            dataGridYT.DataSource = list;
        }

        private void dataGridYT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUD SaveVideoYT = new CRUD();
            dataGridYT.Rows[e.RowIndex].Selected = true;
            if (dataGridYT.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                string Title = dataGridYT.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Link = dataGridYT.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ChannelTitle = dataGridYT.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Description = dataGridYT.Rows[e.RowIndex].Cells[3].Value.ToString();
                YouTubeVideo oVideo = new YouTubeVideo()
                {
                    sVideoTitle = Title,
                    sVideoLink = Link,
                    sChannelTitle = ChannelTitle,
                    sDescription = Description,
                };
                SaveVideoYT.SaveVideo(oVideo);
            }
            CRUD Videi = new CRUD();
            dgMojiVidei.DataSource = Videi.GetVideosDB();
        }

        private void dgMojiVidei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUD DeleteVideoYT = new CRUD();
            dgMojiVidei.Rows[e.RowIndex].Selected = true;
            if (dgMojiVidei.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                string ID = dgMojiVidei.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Naziv = dgMojiVidei.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Link = dgMojiVidei.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Opis = dgMojiVidei.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Kanal = dgMojiVidei.Rows[e.RowIndex].Cells[4].Value.ToString();
                YouTubeVideo oVideo = new YouTubeVideo()
                {
                    nVideoID = Int32.Parse(ID),
                    sVideoTitle = Naziv,
                    sVideoLink = Link,
                    sChannelTitle = Kanal,
                    sDescription = Opis,
                };
                DeleteVideoYT.DeleteVideo(oVideo);
                CRUD cVidei = new CRUD();
                dgMojiVidei.DataSource = cVidei.GetVideosDB();
            }

        }
    }
}
