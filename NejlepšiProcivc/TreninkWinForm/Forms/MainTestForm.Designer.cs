namespace TreninkWinForm
{
    partial class MainTestForm
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
            dataGridView1 = new DataGridView();
            button_Message = new Button();
            button_Edit = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            button_OpenSecondForm = new Button();
            button_Grafs = new Button();
            button_Hodiny = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 396);
            dataGridView1.TabIndex = 0;
            // 
            // button_Message
            // 
            button_Message.Location = new Point(12, 414);
            button_Message.Name = "button_Message";
            button_Message.Size = new Size(75, 23);
            button_Message.TabIndex = 1;
            button_Message.Text = "Zpráva";
            button_Message.UseVisualStyleBackColor = true;
            button_Message.Click += button_Message_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(632, 414);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(75, 23);
            button_Edit.TabIndex = 2;
            button_Edit.Text = "Upravit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(713, 414);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 3;
            button_Delete.Text = "Smazat";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(551, 414);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 4;
            button_Add.Text = "Přidat";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_OpenSecondForm
            // 
            button_OpenSecondForm.Location = new Point(295, 415);
            button_OpenSecondForm.Name = "button_OpenSecondForm";
            button_OpenSecondForm.Size = new Size(152, 23);
            button_OpenSecondForm.TabIndex = 5;
            button_OpenSecondForm.Text = "Otevři 2 formulář";
            button_OpenSecondForm.UseVisualStyleBackColor = true;
            button_OpenSecondForm.Click += button_OpenSecondForm_Click;
            // 
            // button_Grafs
            // 
            button_Grafs.Location = new Point(214, 415);
            button_Grafs.Name = "button_Grafs";
            button_Grafs.Size = new Size(75, 23);
            button_Grafs.TabIndex = 6;
            button_Grafs.Text = "Grafy";
            button_Grafs.UseVisualStyleBackColor = true;
            button_Grafs.Click += button_Grafs_Click;
            // 
            // button_Hodiny
            // 
            button_Hodiny.Location = new Point(133, 415);
            button_Hodiny.Name = "button_Hodiny";
            button_Hodiny.Size = new Size(75, 23);
            button_Hodiny.TabIndex = 7;
            button_Hodiny.Text = "Hodiny";
            button_Hodiny.UseVisualStyleBackColor = true;
            button_Hodiny.Click += button_Hodiny_Click;
            // 
            // MainTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Hodiny);
            Controls.Add(button_Grafs);
            Controls.Add(button_OpenSecondForm);
            Controls.Add(button_Add);
            Controls.Add(button_Delete);
            Controls.Add(button_Edit);
            Controls.Add(button_Message);
            Controls.Add(dataGridView1);
            Name = "MainTestForm";
            Text = "MainTestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_Message;
        private Button button_Remove;
        private Button button_Delete;
        private Button button_Add;
        private Button button_OpenSecondForm;
        private Button button_Edit;
        private Button button_Grafs;
        private Button button_Hodiny;
    }
}