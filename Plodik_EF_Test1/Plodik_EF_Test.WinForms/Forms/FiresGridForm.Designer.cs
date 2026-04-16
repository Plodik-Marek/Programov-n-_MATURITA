namespace Plodik_EF_Test.WinForms
{
    partial class FiresGridForm
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
            dataGridView_Fires = new DataGridView();
            button_Add = new Button();
            button_Update = new Button();
            button_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fires).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Fires
            // 
            dataGridView_Fires.AllowUserToAddRows = false;
            dataGridView_Fires.AllowUserToDeleteRows = false;
            dataGridView_Fires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fires.Location = new Point(246, 49);
            dataGridView_Fires.Name = "dataGridView_Fires";
            dataGridView_Fires.ReadOnly = true;
            dataGridView_Fires.Size = new Size(240, 150);
            dataGridView_Fires.TabIndex = 0;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(178, 306);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(294, 306);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 2;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(443, 306);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 3;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // FiresGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Delete);
            Controls.Add(button_Update);
            Controls.Add(button_Add);
            Controls.Add(dataGridView_Fires);
            Name = "FiresGridForm";
            Text = "FiresGridForm";
            Load += FiresGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fires).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Fires;
        private Button button_Add;
        private Button button_Update;
        private Button button_Delete;
    }
}