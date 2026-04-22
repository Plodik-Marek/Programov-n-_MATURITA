namespace Formy_s_parserem.Forms
{
    partial class Graf
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
            pictureBox_Graf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Graf).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Graf
            // 
            pictureBox_Graf.Location = new Point(21, 12);
            pictureBox_Graf.Name = "pictureBox_Graf";
            pictureBox_Graf.Size = new Size(749, 330);
            pictureBox_Graf.TabIndex = 0;
            pictureBox_Graf.TabStop = false;
            pictureBox_Graf.Paint += pictureBox_Graf_Paint;
            // 
            // Graf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_Graf);
            Name = "Graf";
            Text = "Graf";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Graf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Graf;
    }
}