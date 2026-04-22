namespace Formy_s_parserem
{
    partial class MainForm
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
            button_Edit = new Button();
            dataGridView1 = new DataGridView();
            button_New = new Button();
            button_Delete = new Button();
            button_Graf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(127, 364);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(98, 36);
            button_Edit.TabIndex = 0;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 294);
            dataGridView1.TabIndex = 1;
            // 
            // button_New
            // 
            button_New.Location = new Point(23, 364);
            button_New.Name = "button_New";
            button_New.Size = new Size(98, 36);
            button_New.TabIndex = 0;
            button_New.Text = "New";
            button_New.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(231, 364);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(98, 36);
            button_Delete.TabIndex = 0;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Graf
            // 
            button_Graf.Location = new Point(690, 364);
            button_Graf.Name = "button_Graf";
            button_Graf.Size = new Size(98, 36);
            button_Graf.TabIndex = 0;
            button_Graf.Text = "Graf";
            button_Graf.UseVisualStyleBackColor = true;
            button_Graf.Click += button_Graf_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button_Graf);
            Controls.Add(button_Delete);
            Controls.Add(button_New);
            Controls.Add(button_Edit);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_Edit;
        private DataGridView dataGridView1;
        private Button button_New;
        private Button button_Delete;
        private Button button_Graf;
    }
}