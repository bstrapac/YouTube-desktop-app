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
            oSaveButton.Image = Image.FromFile("D:/YouTube_KV/save.png");
            oSaveButton.Width = 40;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridYT.Columns.Add(oSaveButton);
            dataGridYT.AutoGenerateColumns = false;

            List<YouTubeVideo> list1 = rVideo.GetVideosDB();
            dgMojiVidei.DataSource = list1;
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
            YouTubeVideo Video = new YouTubeVideo();
            dataGridYT.Rows[e.RowIndex].Selected = true;
            if (dataGridYT.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                Video.sVideoTitle = dataGridYT.Rows[e.RowIndex].Cells[0].Value.ToString();
                Video.sVideoID = dataGridYT.Rows[e.RowIndex].Cells[1].Value.ToString();
                Video.sChannelTitle = dataGridYT.Rows[e.RowIndex].Cells[2].ToString();
                Video.sDescription= dataGridYT.Rows[e.RowIndex].Cells[3].ToString();
                SaveVideoYT.SaveVideo(Video);
            }

        }
    }
}
