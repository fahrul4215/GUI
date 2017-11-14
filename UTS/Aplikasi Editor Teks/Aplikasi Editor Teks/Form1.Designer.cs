namespace Aplikasi_Editor_Teks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.rb_yellow = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tipeFont = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_ukuranFont = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.b_colorDialog = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_inputText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.output = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_blue);
            this.groupBox1.Controls.Add(this.rb_green);
            this.groupBox1.Controls.Add(this.rb_yellow);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warna Background";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_blue.Location = new System.Drawing.Point(207, 19);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(50, 19);
            this.rb_blue.TabIndex = 2;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Blue";
            this.rb_blue.UseVisualStyleBackColor = true;
            this.rb_blue.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_green.Location = new System.Drawing.Point(107, 19);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(59, 19);
            this.rb_green.TabIndex = 1;
            this.rb_green.TabStop = true;
            this.rb_green.Text = "Green";
            this.rb_green.UseVisualStyleBackColor = true;
            this.rb_green.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_yellow
            // 
            this.rb_yellow.AutoSize = true;
            this.rb_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_yellow.Location = new System.Drawing.Point(6, 19);
            this.rb_yellow.Name = "rb_yellow";
            this.rb_yellow.Size = new System.Drawing.Size(61, 19);
            this.rb_yellow.TabIndex = 0;
            this.rb_yellow.TabStop = true;
            this.rb_yellow.Text = "Yellow";
            this.rb_yellow.UseVisualStyleBackColor = true;
            this.rb_yellow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tipeFont);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipe Font";
            // 
            // cb_tipeFont
            // 
            this.cb_tipeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipeFont.FormattingEnabled = true;
            this.cb_tipeFont.Location = new System.Drawing.Point(6, 15);
            this.cb_tipeFont.Name = "cb_tipeFont";
            this.cb_tipeFont.Size = new System.Drawing.Size(290, 23);
            this.cb_tipeFont.TabIndex = 3;
            this.cb_tipeFont.SelectedIndexChanged += new System.EventHandler(this.cb_tipeFont_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_ukuranFont);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 53);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukuran Font";
            // 
            // cb_ukuranFont
            // 
            this.cb_ukuranFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ukuranFont.FormattingEnabled = true;
            this.cb_ukuranFont.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "36",
            "48"});
            this.cb_ukuranFont.Location = new System.Drawing.Point(6, 19);
            this.cb_ukuranFont.Name = "cb_ukuranFont";
            this.cb_ukuranFont.Size = new System.Drawing.Size(290, 23);
            this.cb_ukuranFont.TabIndex = 4;
            this.cb_ukuranFont.SelectedIndexChanged += new System.EventHandler(this.cb_ukuranFont_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.b_colorDialog);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 55);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Warna Font";
            // 
            // b_colorDialog
            // 
            this.b_colorDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_colorDialog.Location = new System.Drawing.Point(97, 20);
            this.b_colorDialog.Name = "b_colorDialog";
            this.b_colorDialog.Size = new System.Drawing.Size(113, 23);
            this.b_colorDialog.TabIndex = 5;
            this.b_colorDialog.Text = "Color Dialog";
            this.b_colorDialog.UseVisualStyleBackColor = true;
            this.b_colorDialog.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_inputText);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 51);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input Text";
            // 
            // tb_inputText
            // 
            this.tb_inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inputText.Location = new System.Drawing.Point(6, 19);
            this.tb_inputText.Name = "tb_inputText";
            this.tb_inputText.Size = new System.Drawing.Size(290, 21);
            this.tb_inputText.TabIndex = 6;
            this.tb_inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_inputText_KeyDown);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(3, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(303, 105);
            this.output.TabIndex = 8;
            this.output.Text = "UTS GUI";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 293);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 105);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Aplikasi Editor Teks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.RadioButton rb_yellow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tipeFont;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_ukuranFont;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button b_colorDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_inputText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

