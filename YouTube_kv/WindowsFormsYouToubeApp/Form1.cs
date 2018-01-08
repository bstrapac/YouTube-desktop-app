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

namespace WindowsFormsYouToubeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CRUD rVideo = new CRUD();
            DataGridViewImageColumn oSaveButton = new DataGridViewImageColumn();
            oSaveButton.Image = Image.FromFile("D:/YouTube_KV/check.png");
            oSaveButton.Width = 40;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridYT.Columns.Add(oSaveButton);
            dataGridYT.AutoGenerateColumns = false;

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
        private void SaveVideo_btn(object sender, DataGridViewCellEventArgs e)
        {
            CRUD SaveVideoYT = new CRUD();            
            dataGridYT.Rows[e.RowIndex].Selected = true;           
            if (dataGridYT.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                string Title = dataGridYT.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Link = dataGridYT.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ChannelTitle = dataGridYT.Rows[e.RowIndex].Cells[2].ToString();
                string Description= dataGridYT.Rows[e.RowIndex].Cells[3].ToString();
                YouTubeVideo oVideo = new YouTubeVideo()
                {
                    sVideoTitle= Title,
                    sVideoLink= Link,
                    sChannelTitle=ChannelTitle,
                    sDescription=Description,
                };
                SaveVideoYT.SaveVideo(oVideo);              
              }
        }
    }
}
