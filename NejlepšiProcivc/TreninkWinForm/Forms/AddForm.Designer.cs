namespace TreninkWinForm.Forms
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
            textBox_Name = new TextBox();
            richTextBox_Desc = new RichTextBox();
            comboBox_Type = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_Add = new Button();
            button_Cancel = new Button();
            checkBox_FirstLeague = new CheckBox();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 29);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(468, 23);
            textBox_Name.TabIndex = 0;
            // 
            // richTextBox_Desc
            // 
            richTextBox_Desc.Location = new Point(12, 79);
            richTextBox_Desc.Name = "richTextBox_Desc";
            richTextBox_Desc.Size = new Size(468, 96);
            richTextBox_Desc.TabIndex = 1;
            richTextBox_Desc.Text = "";
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(12, 198);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(468, 23);
            comboBox_Type.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Popis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Druh";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(12, 260);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 6;
            button_Add.Text = "Přidat";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(93, 260);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 7;
            button_Cancel.Text = "Zrušit";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // checkBox_FirstLeague
            // 
            checkBox_FirstLeague.AutoSize = true;
            checkBox_FirstLeague.Location = new Point(12, 235);
            checkBox_FirstLeague.Name = "checkBox_FirstLeague";
            checkBox_FirstLeague.Size = new Size(80, 19);
            checkBox_FirstLeague.TabIndex = 9;
            checkBox_FirstLeague.Text = "První liga?";
            checkBox_FirstLeague.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_FirstLeague);
            Controls.Add(button_Cancel);
            Controls.Add(button_Add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Type);
            Controls.Add(richTextBox_Desc);
            Controls.Add(textBox_Name);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private RichTextBox richTextBox_Desc;
        private ComboBox comboBox_Type;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_Add;
        private Button button_Cancel;
        private CheckBox checkBox_FirstLeague;
    }
}