namespace InfoAboutFile2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.NameFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChooseImage = new System.Windows.Forms.Button();
            this.NameVal = new System.Windows.Forms.TextBox();
            this.SizeVal = new System.Windows.Forms.TextBox();
            this.PerVal = new System.Windows.Forms.TextBox();
            this.ComVal = new System.Windows.Forms.TextBox();
            this.ColorVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(476, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Info about:";
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameFile.Location = new System.Drawing.Point(175, 165);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(118, 31);
            this.NameFile.TabIndex = 2;
            this.NameFile.Text = "FileName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(175, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ImageSize:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(175, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resolution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(175, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color depth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(175, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Compression:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChooseImage
            // 
            this.ChooseImage.BackColor = System.Drawing.SystemColors.MenuText;
            this.ChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseImage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChooseImage.Location = new System.Drawing.Point(12, 12);
            this.ChooseImage.Name = "ChooseImage";
            this.ChooseImage.Size = new System.Drawing.Size(128, 113);
            this.ChooseImage.TabIndex = 0;
            this.ChooseImage.Text = "Choose Image";
            this.ChooseImage.UseVisualStyleBackColor = false;
            this.ChooseImage.Click += new System.EventHandler(this.ChooseImage_Click);
            // 
            // NameVal
            // 
            this.NameVal.BackColor = System.Drawing.Color.Black;
            this.NameVal.Enabled = false;
            this.NameVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameVal.Location = new System.Drawing.Point(342, 174);
            this.NameVal.Name = "NameVal";
            this.NameVal.Size = new System.Drawing.Size(402, 38);
            this.NameVal.TabIndex = 9;
            // 
            // SizeVal
            // 
            this.SizeVal.BackColor = System.Drawing.Color.Black;
            this.SizeVal.Enabled = false;
            this.SizeVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.SizeVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SizeVal.Location = new System.Drawing.Point(342, 225);
            this.SizeVal.Name = "SizeVal";
            this.SizeVal.Size = new System.Drawing.Size(402, 38);
            this.SizeVal.TabIndex = 10;
            // 
            // PerVal
            // 
            this.PerVal.BackColor = System.Drawing.Color.Black;
            this.PerVal.Enabled = false;
            this.PerVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.PerVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PerVal.Location = new System.Drawing.Point(342, 283);
            this.PerVal.Name = "PerVal";
            this.PerVal.Size = new System.Drawing.Size(403, 38);
            this.PerVal.TabIndex = 11;
            // 
            // ComVal
            // 
            this.ComVal.BackColor = System.Drawing.Color.Black;
            this.ComVal.Enabled = false;
            this.ComVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.ComVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ComVal.Location = new System.Drawing.Point(342, 395);
            this.ComVal.Name = "ComVal";
            this.ComVal.Size = new System.Drawing.Size(402, 38);
            this.ComVal.TabIndex = 12;
            // 
            // ColorVal
            // 
            this.ColorVal.BackColor = System.Drawing.Color.Black;
            this.ColorVal.Enabled = false;
            this.ColorVal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.ColorVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ColorVal.Location = new System.Drawing.Point(342, 338);
            this.ColorVal.Name = "ColorVal";
            this.ColorVal.Size = new System.Drawing.Size(402, 38);
            this.ColorVal.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorVal);
            this.Controls.Add(this.ComVal);
            this.Controls.Add(this.PerVal);
            this.Controls.Add(this.SizeVal);
            this.Controls.Add(this.NameVal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChooseImage;
        private System.Windows.Forms.TextBox NameVal;
        private System.Windows.Forms.TextBox SizeVal;
        private System.Windows.Forms.TextBox PerVal;
        private System.Windows.Forms.TextBox ComVal;
        private System.Windows.Forms.TextBox ColorVal;
    }
}

