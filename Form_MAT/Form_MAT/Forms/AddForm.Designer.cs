namespace Form_MAT
{
    partial class AddForm
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
            button2 = new Button();
            button_Ok = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(461, 350);
            button2.Name = "button2";
            button2.Size = new Size(139, 69);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(133, 360);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(166, 70);
            button_Ok.TabIndex = 1;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += this.button_Ok_Click_1;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Ok);
            Controls.Add(button2);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button_Ok;
    }
}