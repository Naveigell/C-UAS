namespace UAS.FormPage {
    partial class EventParticipant {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantCellularPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ParticipantName,
            this.ParticipantCellularPhone,
            this.ParticipantType,
            this.ParticipantGender});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1094, 433);
            this.dataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "Nama Peserta";
            this.ParticipantName.MinimumWidth = 6;
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            // 
            // ParticipantCellularPhone
            // 
            this.ParticipantCellularPhone.HeaderText = "No telp";
            this.ParticipantCellularPhone.MinimumWidth = 6;
            this.ParticipantCellularPhone.Name = "ParticipantCellularPhone";
            this.ParticipantCellularPhone.ReadOnly = true;
            // 
            // ParticipantType
            // 
            this.ParticipantType.HeaderText = "Type";
            this.ParticipantType.MinimumWidth = 6;
            this.ParticipantType.Name = "ParticipantType";
            this.ParticipantType.ReadOnly = true;
            // 
            // ParticipantGender
            // 
            this.ParticipantGender.HeaderText = "Gender";
            this.ParticipantGender.MinimumWidth = 6;
            this.ParticipantGender.Name = "ParticipantGender";
            this.ParticipantGender.ReadOnly = true;
            // 
            // EventParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 580);
            this.Controls.Add(this.dataGridView);
            this.Name = "EventParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant";
            this.Load += new System.EventHandler(this.EventParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantCellularPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantGender;
    }
}