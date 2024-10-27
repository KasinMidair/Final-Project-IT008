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
            this.buttonADDIMAGE = new System.Windows.Forms.Button();
            this.buttonBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonADDIMAGE
            // 
            this.buttonADDIMAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonADDIMAGE.Location = new System.Drawing.Point(933, 677);
            this.buttonADDIMAGE.Name = "buttonADDIMAGE";
            this.buttonADDIMAGE.Size = new System.Drawing.Size(269, 61);
            this.buttonADDIMAGE.TabIndex = 0;
            this.buttonADDIMAGE.Text = "ADD IMAGE";
            this.buttonADDIMAGE.UseVisualStyleBackColor = true;
            this.buttonADDIMAGE.Click += new System.EventHandler(this.buttonADDIMAGE_Click);
            // 
            // buttonBACK
            // 
            this.buttonBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonBACK.Location = new System.Drawing.Point(33, 677);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(269, 61);
            this.buttonBACK.TabIndex = 1;
            this.buttonBACK.Text = "BACK";
            this.buttonBACK.UseVisualStyleBackColor = true;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // fGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 765);
            this.Controls.Add(this.buttonBACK);
            this.Controls.Add(this.buttonADDIMAGE);
            this.Name = "fGallery";
            this.Text = "fGallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonADDIMAGE;
        private System.Windows.Forms.Button buttonBACK;
    }
}