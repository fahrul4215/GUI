namespace WindowsFormsApplication1
{
    partial class FormTransaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.namaText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alamatText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tambahanCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jumlahText = new System.Windows.Forms.TextBox();
            this.sewaButton = new System.Windows.Forms.Button();
            this.batalButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bayarText = new System.Windows.Forms.TextBox();
            this.kembaliText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.noText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pemesan";
            // 
            // namaText
            // 
            this.namaText.Location = new System.Drawing.Point(128, 47);
            this.namaText.Name = "namaText";
            this.namaText.Size = new System.Drawing.Size(169, 20);
            this.namaText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // alamatText
            // 
            this.alamatText.Location = new System.Drawing.Point(128, 84);
            this.alamatText.Name = "alamatText";
            this.alamatText.Size = new System.Drawing.Size(300, 20);
            this.alamatText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sewa Tambahan";
            // 
            // tambahanCombo
            // 
            this.tambahanCombo.FormattingEnabled = true;
            this.tambahanCombo.Location = new System.Drawing.Point(128, 126);
            this.tambahanCombo.Name = "tambahanCombo";
            this.tambahanCombo.Size = new System.Drawing.Size(121, 21);
            this.tambahanCombo.TabIndex = 5;
            this.tambahanCombo.SelectedIndexChanged += new System.EventHandler(this.tambahanCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah Jam";
            // 
            // jumlahText
            // 
            this.jumlahText.Location = new System.Drawing.Point(128, 164);
            this.jumlahText.Name = "jumlahText";
            this.jumlahText.Size = new System.Drawing.Size(47, 20);
            this.jumlahText.TabIndex = 7;
            this.jumlahText.TextChanged += new System.EventHandler(this.jumlahText_TextChanged);
            // 
            // sewaButton
            // 
            this.sewaButton.Location = new System.Drawing.Point(229, 278);
            this.sewaButton.Name = "sewaButton";
            this.sewaButton.Size = new System.Drawing.Size(75, 23);
            this.sewaButton.TabIndex = 8;
            this.sewaButton.Text = "Sewa";
            this.sewaButton.UseVisualStyleBackColor = true;
            this.sewaButton.Click += new System.EventHandler(this.sewaButton_Click);
            // 
            // batalButton
            // 
            this.batalButton.Location = new System.Drawing.Point(310, 278);
            this.batalButton.Name = "batalButton";
            this.batalButton.Size = new System.Drawing.Size(75, 23);
            this.batalButton.TabIndex = 9;
            this.batalButton.Text = "Batal";
            this.batalButton.UseVisualStyleBackColor = true;
            this.batalButton.Click += new System.EventHandler(this.batalButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 225);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Harga";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(15, 226);
            this.totalText.Multiline = true;
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(126, 46);
            this.totalText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bayar";
            // 
            // bayarText
            // 
            this.bayarText.Location = new System.Drawing.Point(147, 226);
            this.bayarText.Multiline = true;
            this.bayarText.Name = "bayarText";
            this.bayarText.Size = new System.Drawing.Size(123, 46);
            this.bayarText.TabIndex = 15;
            this.bayarText.TextChanged += new System.EventHandler(this.bayarText_TextChanged);
            // 
            // kembaliText
            // 
            this.kembaliText.Location = new System.Drawing.Point(277, 226);
            this.kembaliText.Multiline = true;
            this.kembaliText.Name = "kembaliText";
            this.kembaliText.Size = new System.Drawing.Size(108, 46);
            this.kembaliText.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kembalian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "No Trans";
            // 
            // noText
            // 
            this.noText.Location = new System.Drawing.Point(78, 4);
            this.noText.Name = "noText";
            this.noText.Size = new System.Drawing.Size(45, 20);
            this.noText.TabIndex = 19;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 314);
            this.Controls.Add(this.noText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kembaliText);
            this.Controls.Add(this.bayarText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.batalButton);
            this.Controls.Add(this.sewaButton);
            this.Controls.Add(this.jumlahText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tambahanCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alamatText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namaText);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alamatText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tambahanCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jumlahText;
        private System.Windows.Forms.Button sewaButton;
        private System.Windows.Forms.Button batalButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bayarText;
        private System.Windows.Forms.TextBox kembaliText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noText;
    }
}