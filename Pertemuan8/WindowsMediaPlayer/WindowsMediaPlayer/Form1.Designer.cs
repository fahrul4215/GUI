namespace WindowsMediaPlayer
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
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.pb_pause = new System.Windows.Forms.PictureBox();
            this.pb_resume = new System.Windows.Forms.PictureBox();
            this.pb_stop = new System.Windows.Forms.PictureBox();
            this.pb_first = new System.Windows.Forms.PictureBox();
            this.pb_prev = new System.Windows.Forms.PictureBox();
            this.pb_next = new System.Windows.Forms.PictureBox();
            this.pb_last = new System.Windows.Forms.PictureBox();
            this.pb_fast = new System.Windows.Forms.PictureBox();
            this.pb_random = new System.Windows.Forms.PictureBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listmusic = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_volume = new System.Windows.Forms.TrackBar();
            this.pb_volume = new System.Windows.Forms.PictureBox();
            this.text_durasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_posisi = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.text_judul = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_file
            // 
            this.open_file.FileName = "openFileDialog1";
            this.open_file.Filter = "MP3 File|*.mp3|WAV File |.wav|MP4 Files|*.mp4|Semua Files|*.* ";
            this.open_file.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.pb_play, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_pause, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_resume, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_stop, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_first, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_prev, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_next, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_last, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_fast, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_random, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 469);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pb_play
            // 
            this.pb_play.Image = ((System.Drawing.Image)(resources.GetObject("pb_play.Image")));
            this.pb_play.Location = new System.Drawing.Point(3, 3);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(56, 49);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 0;
            this.pb_play.TabStop = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // pb_pause
            // 
            this.pb_pause.Image = ((System.Drawing.Image)(resources.GetObject("pb_pause.Image")));
            this.pb_pause.Location = new System.Drawing.Point(65, 3);
            this.pb_pause.Name = "pb_pause";
            this.pb_pause.Size = new System.Drawing.Size(56, 49);
            this.pb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pause.TabIndex = 1;
            this.pb_pause.TabStop = false;
            this.pb_pause.Click += new System.EventHandler(this.pb_pause_Click);
            // 
            // pb_resume
            // 
            this.pb_resume.Image = ((System.Drawing.Image)(resources.GetObject("pb_resume.Image")));
            this.pb_resume.Location = new System.Drawing.Point(127, 3);
            this.pb_resume.Name = "pb_resume";
            this.pb_resume.Size = new System.Drawing.Size(56, 49);
            this.pb_resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resume.TabIndex = 2;
            this.pb_resume.TabStop = false;
            // 
            // pb_stop
            // 
            this.pb_stop.Image = ((System.Drawing.Image)(resources.GetObject("pb_stop.Image")));
            this.pb_stop.Location = new System.Drawing.Point(189, 3);
            this.pb_stop.Name = "pb_stop";
            this.pb_stop.Size = new System.Drawing.Size(56, 49);
            this.pb_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_stop.TabIndex = 3;
            this.pb_stop.TabStop = false;
            this.pb_stop.Click += new System.EventHandler(this.pb_stop_Click);
            // 
            // pb_first
            // 
            this.pb_first.Image = ((System.Drawing.Image)(resources.GetObject("pb_first.Image")));
            this.pb_first.Location = new System.Drawing.Point(251, 3);
            this.pb_first.Name = "pb_first";
            this.pb_first.Size = new System.Drawing.Size(56, 49);
            this.pb_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_first.TabIndex = 4;
            this.pb_first.TabStop = false;
            this.pb_first.Click += new System.EventHandler(this.pb_first_Click);
            // 
            // pb_prev
            // 
            this.pb_prev.Image = ((System.Drawing.Image)(resources.GetObject("pb_prev.Image")));
            this.pb_prev.Location = new System.Drawing.Point(313, 3);
            this.pb_prev.Name = "pb_prev";
            this.pb_prev.Size = new System.Drawing.Size(56, 49);
            this.pb_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_prev.TabIndex = 5;
            this.pb_prev.TabStop = false;
            this.pb_prev.Click += new System.EventHandler(this.pb_prev_Click);
            // 
            // pb_next
            // 
            this.pb_next.Image = ((System.Drawing.Image)(resources.GetObject("pb_next.Image")));
            this.pb_next.Location = new System.Drawing.Point(375, 3);
            this.pb_next.Name = "pb_next";
            this.pb_next.Size = new System.Drawing.Size(56, 49);
            this.pb_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_next.TabIndex = 6;
            this.pb_next.TabStop = false;
            this.pb_next.Click += new System.EventHandler(this.pb_next_Click);
            // 
            // pb_last
            // 
            this.pb_last.Image = ((System.Drawing.Image)(resources.GetObject("pb_last.Image")));
            this.pb_last.Location = new System.Drawing.Point(437, 3);
            this.pb_last.Name = "pb_last";
            this.pb_last.Size = new System.Drawing.Size(56, 49);
            this.pb_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_last.TabIndex = 7;
            this.pb_last.TabStop = false;
            this.pb_last.Click += new System.EventHandler(this.pb_last_Click);
            // 
            // pb_fast
            // 
            this.pb_fast.Image = ((System.Drawing.Image)(resources.GetObject("pb_fast.Image")));
            this.pb_fast.Location = new System.Drawing.Point(561, 3);
            this.pb_fast.Name = "pb_fast";
            this.pb_fast.Size = new System.Drawing.Size(58, 49);
            this.pb_fast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fast.TabIndex = 9;
            this.pb_fast.TabStop = false;
            // 
            // pb_random
            // 
            this.pb_random.Image = ((System.Drawing.Image)(resources.GetObject("pb_random.Image")));
            this.pb_random.Location = new System.Drawing.Point(499, 3);
            this.pb_random.Name = "pb_random";
            this.pb_random.Size = new System.Drawing.Size(56, 49);
            this.pb_random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_random.TabIndex = 8;
            this.pb_random.TabStop = false;
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(3, 3);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(623, 367);
            this.Player.TabIndex = 3;
            this.Player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.26608F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.73392F));
            this.tableLayoutPanel1.Controls.Add(this.listmusic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.78591F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.214092F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listmusic
            // 
            this.listmusic.BackColor = System.Drawing.Color.White;
            this.listmusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listmusic.FormattingEnabled = true;
            this.listmusic.Location = new System.Drawing.Point(632, 3);
            this.listmusic.Name = "listmusic";
            this.tableLayoutPanel1.SetRowSpan(this.listmusic, 2);
            this.listmusic.Size = new System.Drawing.Size(287, 404);
            this.listmusic.TabIndex = 2;
            this.listmusic.SelectedIndexChanged += new System.EventHandler(this.listmusic_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.97902F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.02098F));
            this.tableLayoutPanel3.Controls.Add(this.tb_volume, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pb_volume, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(632, 469);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 55);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tb_volume
            // 
            this.tb_volume.BackColor = System.Drawing.Color.LightSlateGray;
            this.tb_volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_volume.Location = new System.Drawing.Point(63, 3);
            this.tb_volume.Maximum = 100;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(220, 49);
            this.tb_volume.TabIndex = 0;
            this.tb_volume.Scroll += new System.EventHandler(this.tb_volume_Scroll);
            // 
            // pb_volume
            // 
            this.pb_volume.Image = ((System.Drawing.Image)(resources.GetObject("pb_volume.Image")));
            this.pb_volume.Location = new System.Drawing.Point(3, 3);
            this.pb_volume.Name = "pb_volume";
            this.pb_volume.Size = new System.Drawing.Size(53, 49);
            this.pb_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_volume.TabIndex = 1;
            this.pb_volume.TabStop = false;
            // 
            // text_durasi
            // 
            this.text_durasi.AutoSize = true;
            this.text_durasi.Location = new System.Drawing.Point(65, 0);
            this.text_durasi.Name = "text_durasi";
            this.text_durasi.Size = new System.Drawing.Size(34, 13);
            this.text_durasi.TabIndex = 3;
            this.text_durasi.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // text_posisi
            // 
            this.text_posisi.AutoSize = true;
            this.text_posisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_posisi.Location = new System.Drawing.Point(3, 0);
            this.text_posisi.Name = "text_posisi";
            this.text_posisi.Size = new System.Drawing.Size(36, 31);
            this.text_posisi.TabIndex = 2;
            this.text_posisi.Text = "00:00";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar1, 2);
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(3, 413);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(916, 50);
            this.trackBar1.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.11594F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.88406F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 515F));
            this.tableLayoutPanel4.Controls.Add(this.text_judul, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_posisi, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_durasi, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 376);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(623, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // text_judul
            // 
            this.text_judul.AutoSize = true;
            this.text_judul.Location = new System.Drawing.Point(110, 0);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(0, 13);
            this.text_judul.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_pause;
        private System.Windows.Forms.PictureBox pb_resume;
        private System.Windows.Forms.PictureBox pb_stop;
        private System.Windows.Forms.PictureBox pb_first;
        private System.Windows.Forms.PictureBox pb_prev;
        private System.Windows.Forms.PictureBox pb_next;
        private System.Windows.Forms.PictureBox pb_last;
        private System.Windows.Forms.PictureBox pb_fast;
        private System.Windows.Forms.PictureBox pb_random;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listmusic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar tb_volume;
        private System.Windows.Forms.PictureBox pb_volume;
        private System.Windows.Forms.Label text_posisi;
        private System.Windows.Forms.Label text_durasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label text_judul;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

