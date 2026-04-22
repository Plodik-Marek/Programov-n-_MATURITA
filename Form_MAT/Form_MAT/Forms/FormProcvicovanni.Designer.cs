namespace Form_MAT
{
    partial class FormProcvicovanni
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
            dataGridView_Data = new DataGridView();
            button_Edit = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Data
            // 
            dataGridView_Data.AllowUserToAddRows = false;
            dataGridView_Data.AllowUserToDeleteRows = false;
            dataGridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Data.Location = new Point(48, 12);
            dataGridView_Data.Name = "dataGridView_Data";
            dataGridView_Data.ReadOnly = true;
            dataGridView_Data.Size = new Size(697, 364);
            dataGridView_Data.TabIndex = 0;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(190, 395);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(136, 29);
            button_Edit.TabIndex = 1;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(332, 395);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(136, 29);
            button_Delete.TabIndex = 1;
            button_Delete.Text = "delete";
            button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(48, 395);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(136, 29);
            button_Add.TabIndex = 1;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // FormProcvicovanni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(button_Edit);
            Controls.Add(dataGridView_Data);
            Name = "FormProcvicovanni";
            Text = "FormProcvicovanni";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Data;
        private Button button_Edit;
        private Button button_Delete;
        private Button button_Add;
    }
}