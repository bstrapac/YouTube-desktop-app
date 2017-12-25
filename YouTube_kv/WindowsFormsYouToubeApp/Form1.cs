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

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("D:/YouTube_KV/save.png");
            oEditButton.Width = 40;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridYT.Columns.Add(oEditButton);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            REST Video = new REST();
            List<YouTubeVideo> list = Video.GetVideos(inptPretraziYT.Text);
            dataGridYT.DataSource = list;
        }
    }
}
