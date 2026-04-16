namespace Plodik_EF_Test.WinForms
{
    partial class FireEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_Location = new TextBox();
            numericUpDown_Severity = new NumericUpDown();
            textBox_Involement = new TextBox();
            dateTimePicker_Started = new DateTimePicker();
            dateTimePicker_Ended = new DateTimePicker();
            button_Save = new Button();
            button_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Severity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 57);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Severity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Involvement";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 212);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Ended At";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 177);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Started At";
            // 
            // textBox_Location
            // 
            textBox_Location.Location = new Point(207, 57);
            textBox_Location.Name = "textBox_Location";
            textBox_Location.Size = new Size(100, 23);
            textBox_Location.TabIndex = 5;
            // 
            // numericUpDown_Severity
            // 
            numericUpDown_Severity.Location = new Point(207, 95);
            numericUpDown_Severity.Name = "numericUpDown_Severity";
            numericUpDown_Severity.Size = new Size(120, 23);
            numericUpDown_Severity.TabIndex = 6;
            // 
            // textBox_Involement
            // 
            textBox_Involement.Location = new Point(207, 134);
            textBox_Involement.Name = "textBox_Involement";
            textBox_Involement.Size = new Size(100, 23);
            textBox_Involement.TabIndex = 7;
            // 
            // dateTimePicker_Started
            // 
            dateTimePicker_Started.Location = new Point(207, 171);
            dateTimePicker_Started.Name = "dateTimePicker_Started";
            dateTimePicker_Started.Size = new Size(200, 23);
            dateTimePicker_Started.TabIndex = 8;
            // 
            // dateTimePicker_Ended
            // 
            dateTimePicker_Ended.Location = new Point(207, 206);
            dateTimePicker_Ended.Name = "dateTimePicker_Ended";
            dateTimePicker_Ended.Size = new Size(200, 23);
            dateTimePicker_Ended.TabIndex = 9;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(177, 296);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(75, 23);
            button_Save.TabIndex = 10;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(289, 296);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 11;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // FireEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Cancel);
            Controls.Add(button_Save);
            Controls.Add(dateTimePicker_Ended);
            Controls.Add(dateTimePicker_Started);
            Controls.Add(textBox_Involement);
            Controls.Add(numericUpDown_Severity);
            Controls.Add(textBox_Location);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FireEditForm";
            Text = "FireEditForm";
            Load += FireEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Severity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_Location;
        private NumericUpDown numericUpDown_Severity;
        private TextBox textBox_Involement;
        private DateTimePicker dateTimePicker_Started;
        private DateTimePicker dateTimePicker_Ended;
        private Button button_Save;
        private Button button_Cancel;
    }
}