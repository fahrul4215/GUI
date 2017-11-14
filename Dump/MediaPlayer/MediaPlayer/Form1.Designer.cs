namespace MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listMusic = new System.Windows.Forms.ListBox();
            this.tb_volume = new System.Windows.Forms.TrackBar();
            this.text_posisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_durasi = new System.Windows.Forms.Label();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.pb_pause = new System.Windows.Forms.PictureBox();
            this.pb_resume = new System.Windows.Forms.PictureBox();
            this.pb_stop = new System.Windows.Forms.PictureBox();
            this.pb_first = new System.Windows.Forms.PictureBox();
            this.pb_prev = new System.Windows.Forms.PictureBox();
            this.pb_next = new System.Windows.Forms.PictureBox();
            this.pb_last = new System.Windows.Forms.PictureBox();
            this.pb_random = new System.Windows.Forms.PictureBox();
            this.pb_fast = new System.Windows.Forms.PictureBox();
            this.pb_volume = new System.Windows.Forms.PictureBox();
            this.text_judul = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.48418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.51581F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.player, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listMusic, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.28323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.71676F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.70642F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.29358F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.pb_play, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_pause, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_resume, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_stop, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_first, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_prev, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_next, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_last, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_random, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_fast, 9, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 405);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 53);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23376F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Controls.Add(this.tb_volume, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.text_posisi, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.text_durasi, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.pb_volume, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(630, 405);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(284, 53);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // open
            // 
            this.open.FileName = "openFile";
            this.open.Filter = "MP3 File|*.mp3|WAV File|*.wav|MP4 File|*.mp4|Semua File|*.*";
            this.open.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(3, 3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(621, 396);
            this.player.TabIndex = 2;
            // 
            // listMusic
            // 
            this.listMusic.FormattingEnabled = true;
            this.listMusic.Location = new System.Drawing.Point(630, 3);
            this.listMusic.Name = "listMusic";
            this.listMusic.Size = new System.Drawing.Size(284, 355);
            this.listMusic.TabIndex = 3;
            this.listMusic.SelectedIndexChanged += new System.EventHandler(this.listMusic_SelectedIndexChanged);
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(55, 3);
            this.tb_volume.Maximum = 100;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(96, 42);
            this.tb_volume.TabIndex = 0;
            // 
            // text_posisi
            // 
            this.text_posisi.AutoSize = true;
            this.text_posisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_posisi.Location = new System.Drawing.Point(157, 0);
            this.text_posisi.Name = "text_posisi";
            this.text_posisi.Size = new System.Drawing.Size(53, 53);
            this.text_posisi.TabIndex = 1;
            this.text_posisi.Text = "00:00";
            this.text_posisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_durasi
            // 
            this.text_durasi.AutoSize = true;
            this.text_durasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_durasi.Location = new System.Drawing.Point(233, 0);
            this.text_durasi.Name = "text_durasi";
            this.text_durasi.Size = new System.Drawing.Size(48, 53);
            this.text_durasi.TabIndex = 3;
            this.text_durasi.Text = "00:00";
            this.text_durasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_play
            // 
            this.pb_play.Image = ((System.Drawing.Image)(resources.GetObject("pb_play.Image")));
            this.pb_play.Location = new System.Drawing.Point(3, 3);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(46, 47);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 0;
            this.pb_play.TabStop = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // pb_pause
            // 
            this.pb_pause.Image = ((System.Drawing.Image)(resources.GetObject("pb_pause.Image")));
            this.pb_pause.Location = new System.Drawing.Point(55, 3);
            this.pb_pause.Name = "pb_pause";
            this.pb_pause.Size = new System.Drawing.Size(51, 47);
            this.pb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pause.TabIndex = 1;
            this.pb_pause.TabStop = false;
            this.pb_pause.Click += new System.EventHandler(this.pb_pause_Click);
            // 
            // pb_resume
            // 
            this.pb_resume.Image = ((System.Drawing.Image)(resources.GetObject("pb_resume.Image")));
            this.pb_resume.Location = new System.Drawing.Point(112, 3);
            this.pb_resume.Name = "pb_resume";
            this.pb_resume.Size = new System.Drawing.Size(59, 47);
            this.pb_resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resume.TabIndex = 2;
            this.pb_resume.TabStop = false;
            // 
            // pb_stop
            // 
            this.pb_stop.Image = ((System.Drawing.Image)(resources.GetObject("pb_stop.Image")));
            this.pb_stop.Location = new System.Drawing.Point(177, 3);
            this.pb_stop.Name = "pb_stop";
            this.pb_stop.Size = new System.Drawing.Size(57, 47);
            this.pb_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_stop.TabIndex = 3;
            this.pb_stop.TabStop = false;
            this.pb_stop.Click += new System.EventHandler(this.pb_stop_Click);
            // 
            // pb_first
            // 
            this.pb_first.Image = ((System.Drawing.Image)(resources.GetObject("pb_first.Image")));
            this.pb_first.Location = new System.Drawing.Point(240, 3);
            this.pb_first.Name = "pb_first";
            this.pb_first.Size = new System.Drawing.Size(65, 47);
            this.pb_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_first.TabIndex = 4;
            this.pb_first.TabStop = false;
            this.pb_first.Click += new System.EventHandler(this.pb_first_Click);
            // 
            // pb_prev
            // 
            this.pb_prev.Image = ((System.Drawing.Image)(resources.GetObject("pb_prev.Image")));
            this.pb_prev.Location = new System.Drawing.Point(311, 3);
            this.pb_prev.Name = "pb_prev";
            this.pb_prev.Size = new System.Drawing.Size(59, 47);
            this.pb_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_prev.TabIndex = 5;
            this.pb_prev.TabStop = false;
            this.pb_prev.Click += new System.EventHandler(this.pb_prev_Click);
            // 
            // pb_next
            // 
            this.pb_next.Image = ((System.Drawing.Image)(resources.GetObject("pb_next.Image")));
            this.pb_next.Location = new System.Drawing.Point(376, 3);
            this.pb_next.Name = "pb_next";
            this.pb_next.Size = new System.Drawing.Size(52, 47);
            this.pb_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_next.TabIndex = 6;
            this.pb_next.TabStop = false;
            this.pb_next.Click += new System.EventHandler(this.pb_next_Click);
            // 
            // pb_last
            // 
            this.pb_last.Image = ((System.Drawing.Image)(resources.GetObject("pb_last.Image")));
            this.pb_last.Location = new System.Drawing.Point(434, 3);
            this.pb_last.Name = "pb_last";
            this.pb_last.Size = new System.Drawing.Size(51, 47);
            this.pb_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_last.TabIndex = 7;
            this.pb_last.TabStop = false;
            this.pb_last.Click += new System.EventHandler(this.pb_last_Click);
            // 
            // pb_random
            // 
            this.pb_random.Image = ((System.Drawing.Image)(resources.GetObject("pb_random.Image")));
            this.pb_random.Location = new System.Drawing.Point(491, 3);
            this.pb_random.Name = "pb_random";
            this.pb_random.Size = new System.Drawing.Size(56, 47);
            this.pb_random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_random.TabIndex = 8;
            this.pb_random.TabStop = false;
            // 
            // pb_fast
            // 
            this.pb_fast.Image = ((System.Drawing.Image)(resources.GetObject("pb_fast.Image")));
            this.pb_fast.Location = new System.Drawing.Point(553, 3);
            this.pb_fast.Name = "pb_fast";
            this.pb_fast.Size = new System.Drawing.Size(62, 47);
            this.pb_fast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fast.TabIndex = 9;
            this.pb_fast.TabStop = false;
            // 
            // pb_volume
            // 
            this.pb_volume.Image = ((System.Drawing.Image)(resources.GetObject("pb_volume.Image")));
            this.pb_volume.Location = new System.Drawing.Point(3, 3);
            this.pb_volume.Name = "pb_volume";
            this.pb_volume.Size = new System.Drawing.Size(46, 47);
            this.pb_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_volume.TabIndex = 4;
            this.pb_volume.TabStop = false;
            this.pb_volume.Click += new System.EventHandler(this.pb_volume_Click);
            // 
            // text_judul
            // 
            this.text_judul.AutoSize = true;
            this.text_judul.Location = new System.Drawing.Point(466, 33);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(0, 13);
            this.text_judul.TabIndex = 2;
            this.text_judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(790, 520);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(127, 42);
            this.trackBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 544);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_pause;
        private System.Windows.Forms.PictureBox pb_resume;
        private System.Windows.Forms.PictureBox pb_stop;
        private System.Windows.Forms.PictureBox pb_first;
        private System.Windows.Forms.PictureBox pb_prev;
        private System.Windows.Forms.PictureBox pb_next;
        private System.Windows.Forms.PictureBox pb_last;
        private System.Windows.Forms.PictureBox pb_random;
        private System.Windows.Forms.PictureBox pb_fast;
        private System.Windows.Forms.TrackBar tb_volume;
        private System.Windows.Forms.Label text_posisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text_durasi;
        private System.Windows.Forms.PictureBox pb_volume;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listMusic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label text_judul;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

