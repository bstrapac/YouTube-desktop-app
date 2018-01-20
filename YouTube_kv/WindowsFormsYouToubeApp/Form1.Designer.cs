namespace WindowsFormsYouToubeApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PretragaVidea = new System.Windows.Forms.TabPage();
            this.inptPretraziYT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridYT = new System.Windows.Forms.DataGridView();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovKanala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovVidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MojiVideoZapisi = new System.Windows.Forms.TabPage();
            this.dgMojiVidei = new System.Windows.Forms.DataGridView();
            this.LinkVidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisVidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanalVidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thumbnail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playVideo = new System.Windows.Forms.WebBrowser();
            this.TabControlYT = new System.Windows.Forms.TabControl();
            this.PretragaVidea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYT)).BeginInit();
            this.MojiVideoZapisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMojiVidei)).BeginInit();
            this.TabControlYT.SuspendLayout();
            this.SuspendLayout();
            // 
            // PretragaVidea
            // 
            this.PretragaVidea.BackgroundImage = global::WindowsFormsYouToubeApp.Properties.Resources.ytbackground;
            this.PretragaVidea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PretragaVidea.Controls.Add(this.dataGridYT);
            this.PretragaVidea.Controls.Add(this.btnSearch);
            this.PretragaVidea.Controls.Add(this.label1);
            this.PretragaVidea.Controls.Add(this.inptPretraziYT);
            this.PretragaVidea.Location = new System.Drawing.Point(4, 22);
            this.PretragaVidea.Name = "PretragaVidea";
            this.PretragaVidea.Padding = new System.Windows.Forms.Padding(3);
            this.PretragaVidea.Size = new System.Drawing.Size(1015, 498);
            this.PretragaVidea.TabIndex = 1;
            this.PretragaVidea.Text = "Pretraga Video zapisa";
            this.PretragaVidea.UseVisualStyleBackColor = true;
            // 
            // inptPretraziYT
            // 
            this.inptPretraziYT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inptPretraziYT.Location = new System.Drawing.Point(148, 23);
            this.inptPretraziYT.Name = "inptPretraziYT";
            this.inptPretraziYT.Size = new System.Drawing.Size(731, 20);
            this.inptPretraziYT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite pojam za pretragu: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(885, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraži ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridYT
            // 
            this.dataGridYT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridYT.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Slika,
            this.NaslovVidea,
            this.NaslovKanala,
            this.videoID,
            this.Opis});
            this.dataGridYT.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridYT.Location = new System.Drawing.Point(9, 54);
            this.dataGridYT.Name = "dataGridYT";
            this.dataGridYT.Size = new System.Drawing.Size(992, 434);
            this.dataGridYT.TabIndex = 3;
            this.dataGridYT.Visible = false;
            this.dataGridYT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridYT_CellContentClick);
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "sDescription";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Opis.DefaultCellStyle = dataGridViewCellStyle1;
            this.Opis.FillWeight = 200F;
            this.Opis.HeaderText = "Opis Videa";
            this.Opis.Name = "Opis";
            // 
            // videoID
            // 
            this.videoID.DataPropertyName = "sVideoLink";
            this.videoID.HeaderText = "Link Videa";
            this.videoID.Name = "videoID";
            // 
            // NaslovKanala
            // 
            this.NaslovKanala.DataPropertyName = "sChannelTitle";
            this.NaslovKanala.HeaderText = "Kanal";
            this.NaslovKanala.Name = "NaslovKanala";
            this.NaslovKanala.Width = 110;
            // 
            // NaslovVidea
            // 
            this.NaslovVidea.DataPropertyName = "sVideoTitle";
            this.NaslovVidea.HeaderText = "Naslov";
            this.NaslovVidea.Name = "NaslovVidea";
            this.NaslovVidea.Width = 250;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "sVideoImage";
            this.Slika.HeaderText = "Thumbnail";
            this.Slika.Name = "Slika";
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MojiVideoZapisi
            // 
            this.MojiVideoZapisi.BackgroundImage = global::WindowsFormsYouToubeApp.Properties.Resources.ytbackground;
            this.MojiVideoZapisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MojiVideoZapisi.Controls.Add(this.playVideo);
            this.MojiVideoZapisi.Controls.Add(this.dgMojiVidei);
            this.MojiVideoZapisi.Location = new System.Drawing.Point(4, 22);
            this.MojiVideoZapisi.Name = "MojiVideoZapisi";
            this.MojiVideoZapisi.Padding = new System.Windows.Forms.Padding(3);
            this.MojiVideoZapisi.Size = new System.Drawing.Size(1015, 498);
            this.MojiVideoZapisi.TabIndex = 0;
            this.MojiVideoZapisi.Text = "Moji Video zapisi";
            this.MojiVideoZapisi.UseVisualStyleBackColor = true;
            // 
            // dgMojiVidei
            // 
            this.dgMojiVidei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMojiVidei.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dgMojiVidei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMojiVidei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Thumbnail,
            this.VideoNaziv,
            this.KanalVidea,
            this.OpisVidea,
            this.LinkVidea});
            this.dgMojiVidei.Location = new System.Drawing.Point(3, 0);
            this.dgMojiVidei.Name = "dgMojiVidei";
            this.dgMojiVidei.Size = new System.Drawing.Size(998, 125);
            this.dgMojiVidei.TabIndex = 0;
            this.dgMojiVidei.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMojiVidei_CellContentClick);
            // 
            // LinkVidea
            // 
            this.LinkVidea.DataPropertyName = "sVideoLink";
            this.LinkVidea.HeaderText = "Link";
            this.LinkVidea.Name = "LinkVidea";
            // 
            // OpisVidea
            // 
            this.OpisVidea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpisVidea.DataPropertyName = "sDescription";
            this.OpisVidea.FillWeight = 200F;
            this.OpisVidea.HeaderText = "Opis Videa";
            this.OpisVidea.MinimumWidth = 100;
            this.OpisVidea.Name = "OpisVidea";
            // 
            // KanalVidea
            // 
            this.KanalVidea.DataPropertyName = "sChannelTitle";
            this.KanalVidea.HeaderText = "Kanal";
            this.KanalVidea.Name = "KanalVidea";
            this.KanalVidea.Width = 120;
            // 
            // VideoNaziv
            // 
            this.VideoNaziv.DataPropertyName = "sVideoTitle";
            this.VideoNaziv.HeaderText = "Naziv";
            this.VideoNaziv.Name = "VideoNaziv";
            this.VideoNaziv.Width = 300;
            // 
            // Thumbnail
            // 
            this.Thumbnail.DataPropertyName = "sVideoImage";
            this.Thumbnail.HeaderText = "Thumbnail";
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "nVideoID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 35;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // playVideo
            // 
            this.playVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playVideo.Location = new System.Drawing.Point(3, 131);
            this.playVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(1006, 361);
            this.playVideo.TabIndex = 1;
            this.playVideo.Url = new System.Uri("", System.UriKind.Relative);
            this.playVideo.Visible = false;
            // 
            // TabControlYT
            // 
            this.TabControlYT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlYT.Controls.Add(this.MojiVideoZapisi);
            this.TabControlYT.Controls.Add(this.PretragaVidea);
            this.TabControlYT.Location = new System.Drawing.Point(3, 3);
            this.TabControlYT.Name = "TabControlYT";
            this.TabControlYT.SelectedIndex = 0;
            this.TabControlYT.Size = new System.Drawing.Size(1023, 524);
            this.TabControlYT.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 525);
            this.Controls.Add(this.TabControlYT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YouTube Desktop Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PretragaVidea.ResumeLayout(false);
            this.PretragaVidea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYT)).EndInit();
            this.MojiVideoZapisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMojiVidei)).EndInit();
            this.TabControlYT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage PretragaVidea;
        private System.Windows.Forms.DataGridView dataGridYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovVidea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovKanala;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptPretraziYT;
        private System.Windows.Forms.TabPage MojiVideoZapisi;
        private System.Windows.Forms.WebBrowser playVideo;
        private System.Windows.Forms.DataGridView dgMojiVidei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thumbnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanalVidea;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisVidea;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkVidea;
        private System.Windows.Forms.TabControl TabControlYT;
    }
}

