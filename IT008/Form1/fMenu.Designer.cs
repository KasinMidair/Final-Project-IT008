namespace Form1
{
    partial class fMenu
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
            this.buttonPLAY = new System.Windows.Forms.Button();
            this.buttonSETTING = new System.Windows.Forms.Button();
            this.buttonGALLERY = new System.Windows.Forms.Button();
            this.buttonQUIT = new System.Windows.Forms.Button();
            this.buttonACHIVEMENT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPLAY
            // 
            this.buttonPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPLAY.Location = new System.Drawing.Point(399, 238);
            this.buttonPLAY.Name = "buttonPLAY";
            this.buttonPLAY.Size = new System.Drawing.Size(305, 68);
            this.buttonPLAY.TabIndex = 0;
            this.buttonPLAY.Text = "PLAY";
            this.buttonPLAY.UseVisualStyleBackColor = true;
            this.buttonPLAY.Click += new System.EventHandler(this.buttonPLAY_Click);
            // 
            // buttonSETTING
            // 
            this.buttonSETTING.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSETTING.Location = new System.Drawing.Point(399, 327);
            this.buttonSETTING.Name = "buttonSETTING";
            this.buttonSETTING.Size = new System.Drawing.Size(305, 68);
            this.buttonSETTING.TabIndex = 1;
            this.buttonSETTING.Text = "SETTING";
            this.buttonSETTING.UseVisualStyleBackColor = true;
            this.buttonSETTING.Click += new System.EventHandler(this.buttonSETTING_Click);
            // 
            // buttonGALLERY
            // 
            this.buttonGALLERY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGALLERY.Location = new System.Drawing.Point(399, 418);
            this.buttonGALLERY.Name = "buttonGALLERY";
            this.buttonGALLERY.Size = new System.Drawing.Size(305, 68);
            this.buttonGALLERY.TabIndex = 2;
            this.buttonGALLERY.Text = "GALLERY";
            this.buttonGALLERY.UseVisualStyleBackColor = true;
            this.buttonGALLERY.Click += new System.EventHandler(this.buttonGALLERY_Click);
            // 
            // buttonQUIT
            // 
            this.buttonQUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQUIT.Location = new System.Drawing.Point(399, 604);
            this.buttonQUIT.Name = "buttonQUIT";
            this.buttonQUIT.Size = new System.Drawing.Size(305, 68);
            this.buttonQUIT.TabIndex = 3;
            this.buttonQUIT.Text = "QUIT";
            this.buttonQUIT.UseVisualStyleBackColor = true;
            this.buttonQUIT.Click += new System.EventHandler(this.buttonQUIT_Click);
            // 
            // buttonACHIVEMENT
            // 
            this.buttonACHIVEMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonACHIVEMENT.Location = new System.Drawing.Point(399, 511);
            this.buttonACHIVEMENT.Name = "buttonACHIVEMENT";
            this.buttonACHIVEMENT.Size = new System.Drawing.Size(305, 68);
            this.buttonACHIVEMENT.TabIndex = 4;
            this.buttonACHIVEMENT.Text = "ACHIVEMENT";
            this.buttonACHIVEMENT.UseVisualStyleBackColor = true;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 786);
            this.Controls.Add(this.buttonACHIVEMENT);
            this.Controls.Add(this.buttonQUIT);
            this.Controls.Add(this.buttonGALLERY);
            this.Controls.Add(this.buttonSETTING);
            this.Controls.Add(this.buttonPLAY);
            this.Name = "fMenu";
            this.Text = "fMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPLAY;
        private System.Windows.Forms.Button buttonSETTING;
        private System.Windows.Forms.Button buttonGALLERY;
        private System.Windows.Forms.Button buttonQUIT;
        private System.Windows.Forms.Button buttonACHIVEMENT;
    }
}