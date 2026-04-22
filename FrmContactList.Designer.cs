namespace CSHARP260422
{
    partial class FrmContactList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvContacts = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewButtonColumn();
            colUpdate = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnNew = new Button();
            txtSearch = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AllowUserToResizeColumns = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colDetails, colUpdate, colDelete });
            dgvContacts.Location = new Point(12, 67);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersVisible = false;
            dgvContacts.RowHeadersWidth = 62;
            dgvContacts.Size = new Size(725, 327);
            dgvContacts.TabIndex = 0;
            // 
            // colID
            // 
            colID.FillWeight = 1F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.Visible = false;
            // 
            // colName
            // 
            colName.FillWeight = 3F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            // 
            // colDetails
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.RoyalBlue;
            colDetails.DefaultCellStyle = dataGridViewCellStyle1;
            colDetails.FillWeight = 2F;
            colDetails.HeaderText = "";
            colDetails.MinimumWidth = 8;
            colDetails.Name = "colDetails";
            colDetails.Text = "details";
            colDetails.UseColumnTextForButtonValue = true;
            // 
            // colUpdate
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Lime;
            colUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            colUpdate.FillWeight = 2F;
            colUpdate.HeaderText = "";
            colUpdate.MinimumWidth = 8;
            colUpdate.Name = "colUpdate";
            colUpdate.Text = "update";
            colUpdate.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Firebrick;
            colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            colDelete.FillWeight = 2F;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(205, 49);
            btnNew.TabIndex = 1;
            btnNew.Text = "add new contact";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(223, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search contact name...";
            txtSearch.Size = new Size(514, 39);
            txtSearch.TabIndex = 2;
            // 
            // timer
            // 
            timer.Interval = 500;
            // 
            // FrmContactList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 406);
            Controls.Add(txtSearch);
            Controls.Add(btnNew);
            Controls.Add(dgvContacts);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmContactList";
            Text = "Contact manager";
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContacts;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewButtonColumn colDetails;
        private DataGridViewButtonColumn colUpdate;
        private DataGridViewButtonColumn colDelete;
        private Button btnNew;
        private TextBox txtSearch;
        private System.Windows.Forms.Timer timer;
    }
}
