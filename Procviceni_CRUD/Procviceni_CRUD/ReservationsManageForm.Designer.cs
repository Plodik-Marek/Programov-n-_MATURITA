namespace Procviceni_CRUD
{
    partial class ReservationsManageForm
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
            button_Save = new Button();
            button_Cancel = new Button();
            textBox_Name = new TextBox();
            label1 = new Label();
            numericUpDown_Count = new NumericUpDown();
            label2 = new Label();
            numericUpDown_Price = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker_Date = new DateTimePicker();
            checkBox_JePotvrzena = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Count).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Price).BeginInit();
            SuspendLayout();
            // 
            // button_Save
            // 
            button_Save.Location = new Point(199, 352);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(75, 23);
            button_Save.TabIndex = 0;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(408, 352);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(199, 81);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 84);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Jméno";
            label1.Click += label1_Click;
            // 
            // numericUpDown_Count
            // 
            numericUpDown_Count.Location = new Point(199, 121);
            numericUpDown_Count.Name = "numericUpDown_Count";
            numericUpDown_Count.Size = new Size(120, 23);
            numericUpDown_Count.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 123);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Počet";
            label2.Click += label1_Click;
            // 
            // numericUpDown_Price
            // 
            numericUpDown_Price.DecimalPlaces = 1;
            numericUpDown_Price.Location = new Point(199, 167);
            numericUpDown_Price.Name = "numericUpDown_Price";
            numericUpDown_Price.Size = new Size(120, 23);
            numericUpDown_Price.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 167);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Cena";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 204);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Datum";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 244);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 3;
            label5.Text = "Potvrzená?";
            label5.Click += label1_Click;
            // 
            // dateTimePicker_Date
            // 
            dateTimePicker_Date.Location = new Point(199, 204);
            dateTimePicker_Date.Name = "dateTimePicker_Date";
            dateTimePicker_Date.Size = new Size(200, 23);
            dateTimePicker_Date.TabIndex = 5;
            // 
            // checkBox_JePotvrzena
            // 
            checkBox_JePotvrzena.AutoSize = true;
            checkBox_JePotvrzena.Location = new Point(199, 243);
            checkBox_JePotvrzena.Name = "checkBox_JePotvrzena";
            checkBox_JePotvrzena.Size = new Size(48, 19);
            checkBox_JePotvrzena.TabIndex = 6;
            checkBox_JePotvrzena.Text = "Ano";
            checkBox_JePotvrzena.UseVisualStyleBackColor = true;
            // 
            // ReservationsManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_JePotvrzena);
            Controls.Add(dateTimePicker_Date);
            Controls.Add(numericUpDown_Price);
            Controls.Add(numericUpDown_Count);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Name);
            Controls.Add(button_Cancel);
            Controls.Add(button_Save);
            Name = "ReservationsManageForm";
            Text = "ReservationsManageForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Count).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Save;
        private Button button_Cancel;
        private TextBox textBox_Name;
        private Label label1;
        private NumericUpDown numericUpDown_Count;
        private Label label2;
        private NumericUpDown numericUpDown_Price;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker_Date;
        private CheckBox checkBox_JePotvrzena;
    }
}