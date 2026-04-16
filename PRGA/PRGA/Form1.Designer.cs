namespace PRGA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_FullName = new TextBox();
            label6 = new Label();
            label1 = new Label();
            comboBox_Hamburger = new ComboBox();
            label2 = new Label();
            numericUpDown_Eaten = new NumericUpDown();
            label3 = new Label();
            dateTimePicker_LastHamburger = new DateTimePicker();
            dataGridView_Hamburgers = new DataGridView();
            button_Add = new Button();
            button_Delete = new Button();
            button_Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Eaten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Hamburgers).BeginInit();
            SuspendLayout();
            // 
            // textBox_FullName
            // 
            textBox_FullName.BackColor = Color.White;
            textBox_FullName.Location = new Point(154, 41);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(87, 23);
            textBox_FullName.TabIndex = 2;
            textBox_FullName.TextChanged += textBox_FullName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 44);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 19;
            label6.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 93);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 20;
            label1.Text = "Hamburger type:";
            label1.Click += label1_Click;
            // 
            // comboBox_Hamburger
            // 
            comboBox_Hamburger.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Hamburger.FormattingEnabled = true;
            comboBox_Hamburger.Location = new Point(154, 90);
            comboBox_Hamburger.Name = "comboBox_Hamburger";
            comboBox_Hamburger.Size = new Size(121, 23);
            comboBox_Hamburger.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 137);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 22;
            label2.Text = "Eaten:";
            // 
            // numericUpDown_Eaten
            // 
            numericUpDown_Eaten.Location = new Point(155, 129);
            numericUpDown_Eaten.Name = "numericUpDown_Eaten";
            numericUpDown_Eaten.Size = new Size(120, 23);
            numericUpDown_Eaten.TabIndex = 23;
            numericUpDown_Eaten.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 180);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 24;
            label3.Text = "Last hamburger eaten:";
            // 
            // dateTimePicker_LastHamburger
            // 
            dateTimePicker_LastHamburger.Location = new Point(178, 180);
            dateTimePicker_LastHamburger.Name = "dateTimePicker_LastHamburger";
            dateTimePicker_LastHamburger.Size = new Size(200, 23);
            dateTimePicker_LastHamburger.TabIndex = 25;
            // 
            // dataGridView_Hamburgers
            // 
            dataGridView_Hamburgers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Hamburgers.Location = new Point(48, 288);
            dataGridView_Hamburgers.Name = "dataGridView_Hamburgers";
            dataGridView_Hamburgers.Size = new Size(538, 150);
            dataGridView_Hamburgers.TabIndex = 26;
            dataGridView_Hamburgers.CellContentClick += dataGridView_Hamburgers_CellContentClick;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(76, 256);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 27;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(178, 256);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 28;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(279, 256);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(75, 23);
            button_Edit.TabIndex = 29;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(button_Edit);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(dataGridView_Hamburgers);
            Controls.Add(dateTimePicker_LastHamburger);
            Controls.Add(label3);
            Controls.Add(numericUpDown_Eaten);
            Controls.Add(label2);
            Controls.Add(comboBox_Hamburger);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(textBox_FullName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Eaten).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Hamburgers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_FullName;
        private Label label6;
        private Label label1;
        private ComboBox comboBox_Hamburger;
        private Label label2;
        private NumericUpDown numericUpDown_Eaten;
        private Label label3;
        private DateTimePicker dateTimePicker_LastHamburger;
        private DataGridView dataGridView_Hamburgers;
        private Button button_Add;
        private Button button_Delete;
        private Button button_Edit;
    }
}
