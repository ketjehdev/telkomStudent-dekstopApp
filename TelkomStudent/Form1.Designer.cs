namespace TelkomStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.jurusan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(563, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(365, 193);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(243, 58);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(499, 40);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(109, 42);
            this.simpan.TabIndex = 4;
            this.simpan.Text = "Save";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(499, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(499, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // jurusan
            // 
            this.jurusan.FormattingEnabled = true;
            this.jurusan.Location = new System.Drawing.Point(45, 223);
            this.jurusan.Name = "jurusan";
            this.jurusan.Size = new System.Drawing.Size(271, 28);
            this.jurusan.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jurusan";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(45, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(271, 26);
            this.name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // nis
            // 
            this.nis.Location = new System.Drawing.Point(45, 56);
            this.nis.Name = "nis";
            this.nis.Size = new System.Drawing.Size(271, 26);
            this.nis.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kelas";
            // 
            // kelas
            // 
            this.kelas.FormattingEnabled = true;
            this.kelas.Location = new System.Drawing.Point(45, 171);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(271, 28);
            this.kelas.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jurusan);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox jurusan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kelas;
    }
}

