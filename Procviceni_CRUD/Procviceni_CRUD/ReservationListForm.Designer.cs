namespace Procviceni_CRUD
{
    partial class ReservationListForm
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
            components = new System.ComponentModel.Container();
            dataGridView_Reservations = new DataGridView();
            button_Add = new Button();
            button_Edit = new Button();
            button_Remove = new Button();
            button_Detail = new Button();
            reservationBindingSource = new BindingSource(components);
            guestNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestsCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isConfirmedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Reservations
            // 
            dataGridView_Reservations.AutoGenerateColumns = false;
            dataGridView_Reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Reservations.Columns.AddRange(new DataGridViewColumn[] { guestNameDataGridViewTextBoxColumn, guestsCountDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, reservationDateDataGridViewTextBoxColumn, isConfirmedDataGridViewCheckBoxColumn });
            dataGridView_Reservations.DataSource = reservationBindingSource;
            dataGridView_Reservations.Location = new Point(88, 12);
            dataGridView_Reservations.Name = "dataGridView_Reservations";
            dataGridView_Reservations.Size = new Size(547, 263);
            dataGridView_Reservations.TabIndex = 0;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(88, 321);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Přidat";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(169, 321);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(75, 23);
            button_Edit.TabIndex = 1;
            button_Edit.Text = "Upravit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(250, 321);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 1;
            button_Remove.Text = "Smazat";
            button_Remove.UseVisualStyleBackColor = true;
            // 
            // button_Detail
            // 
            button_Detail.Location = new Point(570, 321);
            button_Detail.Name = "button_Detail";
            button_Detail.Size = new Size(75, 23);
            button_Detail.TabIndex = 1;
            button_Detail.Text = "Detail";
            button_Detail.UseVisualStyleBackColor = true;
            button_Detail.Click += button_Detail_Click;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Reservation);
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
            guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            // 
            // guestsCountDataGridViewTextBoxColumn
            // 
            guestsCountDataGridViewTextBoxColumn.DataPropertyName = "GuestsCount";
            guestsCountDataGridViewTextBoxColumn.HeaderText = "GuestsCount";
            guestsCountDataGridViewTextBoxColumn.Name = "guestsCountDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            reservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate";
            reservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate";
            reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            // 
            // isConfirmedDataGridViewCheckBoxColumn
            // 
            isConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "IsConfirmed";
            isConfirmedDataGridViewCheckBoxColumn.HeaderText = "IsConfirmed";
            isConfirmedDataGridViewCheckBoxColumn.Name = "isConfirmedDataGridViewCheckBoxColumn";
            // 
            // ReservationListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Detail);
            Controls.Add(button_Remove);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(dataGridView_Reservations);
            Name = "ReservationListForm";
            Text = "ReservationListForm";
            Load += ReservationListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Reservations;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Remove;
        private Button button_Detail;
        private DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestsCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isConfirmedDataGridViewCheckBoxColumn;
        private BindingSource reservationBindingSource;
    }
}