namespace WindowsFormsApplication1
{
    partial class FormTambahan
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
            this.simpanButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // namaText
            // 
            this.namaText.Location = new System.Drawing.Point(99, 55);
            this.namaText.Name = "namaText";
            this.namaText.Size = new System.Drawing.Size(100, 20);
            this.namaText.TabIndex = 1;
            // 
            // simpanButton
            // 
            this.simpanButton.Location = new System.Drawing.Point(99, 103);
            this.simpanButton.Name = "simpanButton";
            this.simpanButton.Size = new System.Drawing.Size(75, 23);
            this.simpanButton.TabIndex = 2;
            this.simpanButton.Text = "Simpan";
            this.simpanButton.UseVisualStyleBackColor = true;
            this.simpanButton.Click += new System.EventHandler(this.simpanButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormTambahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpanButton);
            this.Controls.Add(this.namaText);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahan";
            this.Text = "FormTambahan";
            this.Load += new System.EventHandler(this.FormTambahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaText;
        private System.Windows.Forms.Button simpanButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}