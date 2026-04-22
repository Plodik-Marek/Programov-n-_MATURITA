namespace TreninkWinForm
{
    partial class SecondForm
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
            button_Ok = new Button();
            button_Cancel = new Button();
            textBox_Score = new TextBox();
            comboBox_Club = new ComboBox();
            numericUpDown_Cards = new NumericUpDown();
            dateTimePicker_Date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cards).BeginInit();
            SuspendLayout();
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(632, 411);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 0;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(713, 411);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 0;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // textBox_Score
            // 
            textBox_Score.Location = new Point(12, 67);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(325, 23);
            textBox_Score.TabIndex = 1;
            // 
            // comboBox_Club
            // 
            comboBox_Club.FormattingEnabled = true;
            comboBox_Club.Location = new Point(12, 24);
            comboBox_Club.Name = "comboBox_Club";
            comboBox_Club.Size = new Size(325, 23);
            comboBox_Club.TabIndex = 2;
            // 
            // numericUpDown_Cards
            // 
            numericUpDown_Cards.Location = new Point(12, 116);
            numericUpDown_Cards.Name = "numericUpDown_Cards";
            numericUpDown_Cards.Size = new Size(325, 23);
            numericUpDown_Cards.TabIndex = 3;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Location = new Point(12, 161);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(325, 23);
            dateTimePicker_Date.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Klub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Skóre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Počet karet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Datum utkání";
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Date);
            Controls.Add(numericUpDown_Cards);
            Controls.Add(comboBox_Club);
            Controls.Add(textBox_Score);
            Controls.Add(button_Cancel);
            Controls.Add(button_Ok);
            Name = "SecondForm";
            Text = "SecondForm";
            Load += SecondForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Cards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Ok;
        private Button button_Cancel;
        private TextBox textBox_Score;
        private ComboBox comboBox_Club;
        private NumericUpDown numericUpDown_Cards;
        private DateTimePicker dateTimePicker_Date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}