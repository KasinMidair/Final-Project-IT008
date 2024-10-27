namespace Form1
{
    partial class fSetting
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
            this.checkBoxBackgroundMusic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxBackgroundMusic
            // 
            this.checkBoxBackgroundMusic.AutoSize = true;
            this.checkBoxBackgroundMusic.Checked = true;
            this.checkBoxBackgroundMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackgroundMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBoxBackgroundMusic.Location = new System.Drawing.Point(168, 157);
            this.checkBoxBackgroundMusic.Name = "checkBoxBackgroundMusic";
            this.checkBoxBackgroundMusic.Size = new System.Drawing.Size(376, 50);
            this.checkBoxBackgroundMusic.TabIndex = 0;
            this.checkBoxBackgroundMusic.Text = "Background Music";
            this.checkBoxBackgroundMusic.UseVisualStyleBackColor = true;
            this.checkBoxBackgroundMusic.CheckedChanged += new System.EventHandler(this.checkBoxBackgroundMusic_CheckedChanged);
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 804);
            this.Controls.Add(this.checkBoxBackgroundMusic);
            this.Name = "fSetting";
            this.Text = "fSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBackgroundMusic;
    }
}