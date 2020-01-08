namespace UAS.Page {
    partial class ParticipantPageShowPageDetails {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPage = new System.Windows.Forms.ComboBox();
            this.linkLabelPrint = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.IDParticipant,
            this.ParticipantName,
            this.ParticipantType,
            this.EventGender});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(951, 375);
            this.dataGridView.TabIndex = 1;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "No";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // IDParticipant
            // 
            this.IDParticipant.HeaderText = "ID Peserta";
            this.IDParticipant.MinimumWidth = 6;
            this.IDParticipant.Name = "IDParticipant";
            this.IDParticipant.ReadOnly = true;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "Nama Peserta";
            this.ParticipantName.MinimumWidth = 6;
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            // 
            // ParticipantType
            // 
            this.ParticipantType.HeaderText = "Tipe";
            this.ParticipantType.MinimumWidth = 6;
            this.ParticipantType.Name = "ParticipantType";
            this.ParticipantType.ReadOnly = true;
            // 
            // EventGender
            // 
            this.EventGender.HeaderText = "Gender";
            this.EventGender.MinimumWidth = 6;
            this.EventGender.Name = "EventGender";
            this.EventGender.ReadOnly = true;
            // 
            // comboBoxPage
            // 
            this.comboBoxPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPage.FormattingEnabled = true;
            this.comboBoxPage.Location = new System.Drawing.Point(23, 461);
            this.comboBoxPage.Name = "comboBoxPage";
            this.comboBoxPage.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPage.TabIndex = 3;
            this.comboBoxPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxPage_SelectedIndexChanged);
            // 
            // linkLabelPrint
            // 
            this.linkLabelPrint.AutoSize = true;
            this.linkLabelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPrint.Location = new System.Drawing.Point(167, 466);
            this.linkLabelPrint.Name = "linkLabelPrint";
            this.linkLabelPrint.Size = new System.Drawing.Size(44, 20);
            this.linkLabelPrint.TabIndex = 8;
            this.linkLabelPrint.TabStop = true;
            this.linkLabelPrint.Text = "Print";
            // 
            // ParticipantPageShowPageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelPrint);
            this.Controls.Add(this.comboBoxPage);
            this.Controls.Add(this.dataGridView);
            this.Name = "ParticipantPageShowPageDetails";
            this.Size = new System.Drawing.Size(951, 532);
            this.Load += new System.EventHandler(this.ParticipantPageShowPageDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventGender;
        private System.Windows.Forms.ComboBox comboBoxPage;
        private System.Windows.Forms.LinkLabel linkLabelPrint;
    }
}
