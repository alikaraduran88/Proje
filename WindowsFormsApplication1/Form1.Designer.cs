namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.M_sifrele = new System.Windows.Forms.Button();
            this.AlgoritmaTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesaj Giriniz";
            // 
            // mesaj
            // 
            this.mesaj.Location = new System.Drawing.Point(166, 192);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(242, 69);
            this.mesaj.TabIndex = 3;
            // 
            // M_sifrele
            // 
            this.M_sifrele.Location = new System.Drawing.Point(333, 327);
            this.M_sifrele.Name = "M_sifrele";
            this.M_sifrele.Size = new System.Drawing.Size(75, 23);
            this.M_sifrele.TabIndex = 4;
            this.M_sifrele.Text = "Şİfrele";
            this.M_sifrele.UseVisualStyleBackColor = true;
            this.M_sifrele.Click += new System.EventHandler(this.M_sifrele_Click);
            // 
            // AlgoritmaTur
            // 
            this.AlgoritmaTur.FormattingEnabled = true;
            this.AlgoritmaTur.Items.AddRange(new object[] {
            "LSB Algorithm",
            "MSE Algorithm"});
            this.AlgoritmaTur.Location = new System.Drawing.Point(166, 280);
            this.AlgoritmaTur.Name = "AlgoritmaTur";
            this.AlgoritmaTur.Size = new System.Drawing.Size(242, 21);
            this.AlgoritmaTur.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algoritma Türü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlgoritmaTur);
            this.Controls.Add(this.M_sifrele);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Button M_sifrele;
        private System.Windows.Forms.ComboBox AlgoritmaTur;
        private System.Windows.Forms.Label label2;
    }
}

