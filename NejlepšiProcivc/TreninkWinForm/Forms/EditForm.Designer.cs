namespace TreninkWinForm.Forms
{
    partial class EditForm
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
            button_Cancel = new Button();
            button_Add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_Type = new ComboBox();
            richTextBox_Desc = new RichTextBox();
            textBox_Name = new TextBox();
            label4 = new Label();
            checkBox_FirstLeague = new CheckBox();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(93, 307);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 15;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 307);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 14;
            button_Add.Text = "Upravit";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 235);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Druh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 116);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 12;
            label2.Text = "Popis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 64);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "Název";
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(13, 253);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(468, 23);
            comboBox_Type.TabIndex = 10;
            // 
            // richTextBox_Desc
            // 
            richTextBox_Desc.Location = new Point(13, 134);
            richTextBox_Desc.Name = "richTextBox_Desc";
            richTextBox_Desc.Size = new Size(468, 96);
            richTextBox_Desc.TabIndex = 9;
            richTextBox_Desc.Text = "";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(13, 84);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(468, 23);
            textBox_Name.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "EditForm";
            // 
            // checkBox_FirstLeague
            // 
            checkBox_FirstLeague.AutoSize = true;
            checkBox_FirstLeague.Location = new Point(13, 282);
            checkBox_FirstLeague.Name = "checkBox_FirstLeague";
            checkBox_FirstLeague.Size = new Size(80, 19);
            checkBox_FirstLeague.TabIndex = 17;
            checkBox_FirstLeague.Text = "První liga?";
            checkBox_FirstLeague.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_FirstLeague);
            Controls.Add(label4);
            Controls.Add(button_Cancel);
            Controls.Add(button_Add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Type);
            Controls.Add(richTextBox_Desc);
            Controls.Add(textBox_Name);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cancel;
        private Button button_Add;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_Type;
        private RichTextBox richTextBox_Desc;
        private TextBox textBox_Name;
        private Label label4;
        private CheckBox checkBox_FirstLeague;
    }
}