namespace Form1
{
    partial class fAddImage
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
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonCHOOSEIMAGE = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonADD.Location = new System.Drawing.Point(578, 802);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(158, 59);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonCHOOSEIMAGE
            // 
            this.buttonCHOOSEIMAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonCHOOSEIMAGE.Location = new System.Drawing.Point(227, 802);
            this.buttonCHOOSEIMAGE.Name = "buttonCHOOSEIMAGE";
            this.buttonCHOOSEIMAGE.Size = new System.Drawing.Size(345, 59);
            this.buttonCHOOSEIMAGE.TabIndex = 1;
            this.buttonCHOOSEIMAGE.Text = "CHOOSE IMAGE";
            this.buttonCHOOSEIMAGE.UseVisualStyleBackColor = true;
            this.buttonCHOOSEIMAGE.Click += new System.EventHandler(this.buttonCHOOSEIMAGE_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonCANCEL.Location = new System.Drawing.Point(36, 802);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(185, 59);
            this.buttonCANCEL.TabIndex = 2;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(36, 737);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 39);
            this.textBox1.TabIndex = 4;
            // 
            // fAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 912);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonCHOOSEIMAGE);
            this.Controls.Add(this.buttonADD);
            this.Name = "fAddImage";
            this.Text = "fAddImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonCHOOSEIMAGE;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}