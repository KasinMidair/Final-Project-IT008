namespace Form1
{
    partial class fGallery
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
            this.buttonBACK = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListView();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.buttonDELLETE = new System.Windows.Forms.Button();
            this.buttonRENAME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonADD.Location = new System.Drawing.Point(983, 756);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(112, 61);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonBACK
            // 
            this.buttonBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonBACK.Location = new System.Drawing.Point(348, 756);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(139, 61);
            this.buttonBACK.TabIndex = 1;
            this.buttonBACK.Text = "BACK";
            this.buttonBACK.UseVisualStyleBackColor = true;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // imageList
            // 
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(33, 3);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(292, 814);
            this.imageList.TabIndex = 2;
            this.imageList.UseCompatibleStateImageBehavior = false;
            // 
            // selectedImage
            // 
            this.selectedImage.Location = new System.Drawing.Point(348, 3);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(747, 747);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectedImage.TabIndex = 3;
            this.selectedImage.TabStop = false;
            // 
            // buttonDELLETE
            // 
            this.buttonDELLETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDELLETE.Location = new System.Drawing.Point(744, 756);
            this.buttonDELLETE.Name = "buttonDELLETE";
            this.buttonDELLETE.Size = new System.Drawing.Size(207, 61);
            this.buttonDELLETE.TabIndex = 4;
            this.buttonDELLETE.Text = "DELLETE";
            this.buttonDELLETE.UseVisualStyleBackColor = true;
            this.buttonDELLETE.Click += new System.EventHandler(this.buttonDELLETE_Click);
            // 
            // buttonRENAME
            // 
            this.buttonRENAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonRENAME.Location = new System.Drawing.Point(516, 756);
            this.buttonRENAME.Name = "buttonRENAME";
            this.buttonRENAME.Size = new System.Drawing.Size(201, 61);
            this.buttonRENAME.TabIndex = 5;
            this.buttonRENAME.Text = "RENAME";
            this.buttonRENAME.UseVisualStyleBackColor = true;
            this.buttonRENAME.Click += new System.EventHandler(this.buttonRENAME_Click);
            // 
            // fGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 829);
            this.Controls.Add(this.buttonRENAME);
            this.Controls.Add(this.buttonDELLETE);
            this.Controls.Add(this.selectedImage);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.buttonBACK);
            this.Controls.Add(this.buttonADD);
            this.Name = "fGallery";
            this.Text = "fGallery";
            this.Load += new System.EventHandler(this.fGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonBACK;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.Button buttonDELLETE;
        private System.Windows.Forms.Button buttonRENAME;
    }
}