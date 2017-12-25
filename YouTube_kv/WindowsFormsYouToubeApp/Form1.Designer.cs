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
            this.TabControlYT = new System.Windows.Forms.TabControl();
            this.MojiVideoZapisi = new System.Windows.Forms.TabPage();
            this.PretragaVidea = new System.Windows.Forms.TabPage();
            this.inptPretraziYT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridYT = new System.Windows.Forms.DataGridView();
            this.NaslovVidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovKanala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlYT.SuspendLayout();
            this.PretragaVidea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYT)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlYT
            // 
            this.TabControlYT.Controls.Add(this.MojiVideoZapisi);
            this.TabControlYT.Controls.Add(this.PretragaVidea);
            this.TabControlYT.Location = new System.Drawing.Point(3, 3);
            this.TabControlYT.Name = "TabControlYT";
            this.TabControlYT.SelectedIndex = 0;
            this.TabControlYT.Size = new System.Drawing.Size(737, 360);
            this.TabControlYT.TabIndex = 0;
            // 
            // MojiVideoZapisi
            // 
            this.MojiVideoZapisi.Location = new System.Drawing.Point(4, 22);
            this.MojiVideoZapisi.Name = "MojiVideoZapisi";
            this.MojiVideoZapisi.Padding = new System.Windows.Forms.Padding(3);
            this.MojiVideoZapisi.Size = new System.Drawing.Size(729, 334);
            this.MojiVideoZapisi.TabIndex = 0;
            this.MojiVideoZapisi.Text = "Moji Video zapisi";
            this.MojiVideoZapisi.UseVisualStyleBackColor = true;
            // 
            // PretragaVidea
            // 
            this.PretragaVidea.Controls.Add(this.dataGridYT);
            this.PretragaVidea.Controls.Add(this.btnSearch);
            this.PretragaVidea.Controls.Add(this.label1);
            this.PretragaVidea.Controls.Add(this.inptPretraziYT);
            this.PretragaVidea.Location = new System.Drawing.Point(4, 22);
            this.PretragaVidea.Name = "PretragaVidea";
            this.PretragaVidea.Padding = new System.Windows.Forms.Padding(3);
            this.PretragaVidea.Size = new System.Drawing.Size(729, 334);
            this.PretragaVidea.TabIndex = 1;
            this.PretragaVidea.Text = "Pretraga Video zapisa";
            this.PretragaVidea.UseVisualStyleBackColor = true;
            // 
            // inptPretraziYT
            // 
            this.inptPretraziYT.Location = new System.Drawing.Point(148, 23);
            this.inptPretraziYT.Name = "inptPretraziYT";
            this.inptPretraziYT.Size = new System.Drawing.Size(158, 20);
            this.inptPretraziYT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite pojam za pretragu: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraži ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridYT
            // 
            this.dataGridYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NaslovVidea,
            this.NaslovKanala,
            this.Opis});
            this.dataGridYT.Location = new System.Drawing.Point(9, 49);
            this.dataGridYT.Name = "dataGridYT";
            this.dataGridYT.Size = new System.Drawing.Size(714, 273);
            this.dataGridYT.TabIndex = 3;
            // 
            // NaslovVidea
            // 
            this.NaslovVidea.DataPropertyName = "sVideoTitle";
            this.NaslovVidea.HeaderText = "Naslov";
            this.NaslovVidea.Name = "NaslovVidea";
            this.NaslovVidea.Width = 200;
            // 
            // NaslovKanala
            // 
            this.NaslovKanala.DataPropertyName = "sChannelTitle";
            this.NaslovKanala.HeaderText = "Kanal";
            this.NaslovKanala.Name = "NaslovKanala";
            this.NaslovKanala.Width = 50;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "sDescription";
            this.Opis.HeaderText = "OpisVidea";
            this.Opis.Name = "Opis";
            this.Opis.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 365);
            this.Controls.Add(this.TabControlYT);
            this.Name = "Form1";
            this.Text = "YouTube Desktop Application";
            this.TabControlYT.ResumeLayout(false);
            this.PretragaVidea.ResumeLayout(false);
            this.PretragaVidea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlYT;
        private System.Windows.Forms.TabPage MojiVideoZapisi;
        private System.Windows.Forms.TabPage PretragaVidea;
        private System.Windows.Forms.DataGridView dataGridYT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptPretraziYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovVidea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovKanala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}

