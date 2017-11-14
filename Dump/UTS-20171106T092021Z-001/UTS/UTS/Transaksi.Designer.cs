namespace UTS
{
    partial class Transaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hargatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.providercomboBox = new System.Windows.Forms.ComboBox();
            this.nominalcomboBox = new System.Windows.Forms.ComboBox();
            this.nomerTmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SimpanTbutton = new System.Windows.Forms.Button();
            this.HapusTbutton = new System.Windows.Forms.Button();
            this.saldotextBox = new System.Windows.Forms.TextBox();
            this.ceksaldobutton = new System.Windows.Forms.Button();
            this.tambahsaldobutton = new System.Windows.Forms.Button();
            this.bayarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 140);
            this.dataGridView1.TabIndex = 1;
            // 
            // hargatextBox
            // 
            this.hargatextBox.Location = new System.Drawing.Point(104, 110);
            this.hargatextBox.Name = "hargatextBox";
            this.hargatextBox.Size = new System.Drawing.Size(156, 20);
            this.hargatextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nominal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Provider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nomer";
            // 
            // providercomboBox
            // 
            this.providercomboBox.FormattingEnabled = true;
            this.providercomboBox.Items.AddRange(new object[] {
            "IM3 Oredoo",
            "Simpati",
            "XL"});
            this.providercomboBox.Location = new System.Drawing.Point(104, 49);
            this.providercomboBox.Name = "providercomboBox";
            this.providercomboBox.Size = new System.Drawing.Size(156, 21);
            this.providercomboBox.TabIndex = 10;
            // 
            // nominalcomboBox
            // 
            this.nominalcomboBox.FormattingEnabled = true;
            this.nominalcomboBox.Items.AddRange(new object[] {
            "5000",
            "10000",
            "20000"});
            this.nominalcomboBox.Location = new System.Drawing.Point(104, 78);
            this.nominalcomboBox.Name = "nominalcomboBox";
            this.nominalcomboBox.Size = new System.Drawing.Size(156, 21);
            this.nominalcomboBox.TabIndex = 11;
            this.nominalcomboBox.SelectedIndexChanged += new System.EventHandler(this.nominalcomboBox_SelectedIndexChanged);
            // 
            // nomerTmaskedTextBox
            // 
            this.nomerTmaskedTextBox.Location = new System.Drawing.Point(104, 140);
            this.nomerTmaskedTextBox.Mask = "+62 000 0000 0000";
            this.nomerTmaskedTextBox.Name = "nomerTmaskedTextBox";
            this.nomerTmaskedTextBox.Size = new System.Drawing.Size(156, 20);
            this.nomerTmaskedTextBox.TabIndex = 12;
            // 
            // SimpanTbutton
            // 
            this.SimpanTbutton.Location = new System.Drawing.Point(104, 171);
            this.SimpanTbutton.Name = "SimpanTbutton";
            this.SimpanTbutton.Size = new System.Drawing.Size(75, 23);
            this.SimpanTbutton.TabIndex = 13;
            this.SimpanTbutton.Text = "SIMPAN";
            this.SimpanTbutton.UseVisualStyleBackColor = true;
            this.SimpanTbutton.Click += new System.EventHandler(this.SimpanTbutton_Click);
            // 
            // HapusTbutton
            // 
            this.HapusTbutton.Location = new System.Drawing.Point(185, 170);
            this.HapusTbutton.Name = "HapusTbutton";
            this.HapusTbutton.Size = new System.Drawing.Size(75, 23);
            this.HapusTbutton.TabIndex = 14;
            this.HapusTbutton.Text = "HAPUS";
            this.HapusTbutton.UseVisualStyleBackColor = true;
            this.HapusTbutton.Click += new System.EventHandler(this.HapusTbutton_Click);
            // 
            // saldotextBox
            // 
            this.saldotextBox.Location = new System.Drawing.Point(350, 50);
            this.saldotextBox.Name = "saldotextBox";
            this.saldotextBox.Size = new System.Drawing.Size(174, 20);
            this.saldotextBox.TabIndex = 15;
            // 
            // ceksaldobutton
            // 
            this.ceksaldobutton.Location = new System.Drawing.Point(350, 75);
            this.ceksaldobutton.Name = "ceksaldobutton";
            this.ceksaldobutton.Size = new System.Drawing.Size(45, 23);
            this.ceksaldobutton.TabIndex = 16;
            this.ceksaldobutton.Text = "CEK";
            this.ceksaldobutton.UseVisualStyleBackColor = true;
            // 
            // tambahsaldobutton
            // 
            this.tambahsaldobutton.Location = new System.Drawing.Point(457, 75);
            this.tambahsaldobutton.Name = "tambahsaldobutton";
            this.tambahsaldobutton.Size = new System.Drawing.Size(67, 23);
            this.tambahsaldobutton.TabIndex = 17;
            this.tambahsaldobutton.Text = "TAMBAH";
            this.tambahsaldobutton.UseVisualStyleBackColor = true;
            this.tambahsaldobutton.Click += new System.EventHandler(this.tambahsaldobutton_Click);
            // 
            // bayarbutton
            // 
            this.bayarbutton.Location = new System.Drawing.Point(398, 75);
            this.bayarbutton.Name = "bayarbutton";
            this.bayarbutton.Size = new System.Drawing.Size(53, 23);
            this.bayarbutton.TabIndex = 18;
            this.bayarbutton.Text = "BAYAR";
            this.bayarbutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Saldo";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bayarbutton);
            this.Controls.Add(this.tambahsaldobutton);
            this.Controls.Add(this.ceksaldobutton);
            this.Controls.Add(this.saldotextBox);
            this.Controls.Add(this.HapusTbutton);
            this.Controls.Add(this.SimpanTbutton);
            this.Controls.Add(this.nomerTmaskedTextBox);
            this.Controls.Add(this.nominalcomboBox);
            this.Controls.Add(this.providercomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hargatextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox hargatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox providercomboBox;
        private System.Windows.Forms.ComboBox nominalcomboBox;
        private System.Windows.Forms.MaskedTextBox nomerTmaskedTextBox;
        private System.Windows.Forms.Button SimpanTbutton;
        private System.Windows.Forms.Button HapusTbutton;
        private System.Windows.Forms.TextBox saldotextBox;
        private System.Windows.Forms.Button ceksaldobutton;
        private System.Windows.Forms.Button tambahsaldobutton;
        private System.Windows.Forms.Button bayarbutton;
        private System.Windows.Forms.Label label6;
    }
}