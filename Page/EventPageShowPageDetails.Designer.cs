namespace UAS.Page {
    partial class EventPageShowPageDetails {
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
            this.IDEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTambahEvent = new System.Windows.Forms.Button();
            this.comboBoxPage = new System.Windows.Forms.ComboBox();
            this.buttonLihatPeserta = new System.Windows.Forms.Button();
            this.buttonLihatHasil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.IDEvent,
            this.EventName,
            this.EventStartTime,
            this.EventEnd,
            this.EventType,
            this.EventGender,
            this.EventDescription,
            this.EventStatus});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(951, 375);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellLeave);
            this.dataGridView.LostFocus += new System.EventHandler(this.DataGridViewOnLostFocus);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "No";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 125;
            // 
            // IDEvent
            // 
            this.IDEvent.HeaderText = "ID Event";
            this.IDEvent.MinimumWidth = 6;
            this.IDEvent.Name = "IDEvent";
            this.IDEvent.Width = 125;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Nama Event";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.Width = 125;
            // 
            // EventStartTime
            // 
            this.EventStartTime.HeaderText = "Tanggal Mulai";
            this.EventStartTime.MinimumWidth = 6;
            this.EventStartTime.Name = "EventStartTime";
            this.EventStartTime.Width = 125;
            // 
            // EventEnd
            // 
            this.EventEnd.HeaderText = "Tanggal Selesai";
            this.EventEnd.MinimumWidth = 6;
            this.EventEnd.Name = "EventEnd";
            this.EventEnd.Width = 125;
            // 
            // EventType
            // 
            this.EventType.HeaderText = "Tipe";
            this.EventType.MinimumWidth = 6;
            this.EventType.Name = "EventType";
            this.EventType.Width = 125;
            // 
            // EventGender
            // 
            this.EventGender.HeaderText = "Gender";
            this.EventGender.MinimumWidth = 6;
            this.EventGender.Name = "EventGender";
            this.EventGender.Width = 125;
            // 
            // EventDescription
            // 
            this.EventDescription.HeaderText = "Deskripsi";
            this.EventDescription.MinimumWidth = 6;
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.Width = 125;
            // 
            // EventStatus
            // 
            this.EventStatus.HeaderText = "Status";
            this.EventStatus.MinimumWidth = 6;
            this.EventStatus.Name = "EventStatus";
            this.EventStatus.Width = 125;
            // 
            // buttonTambahEvent
            // 
            this.buttonTambahEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahEvent.Location = new System.Drawing.Point(13, 400);
            this.buttonTambahEvent.Name = "buttonTambahEvent";
            this.buttonTambahEvent.Size = new System.Drawing.Size(130, 53);
            this.buttonTambahEvent.TabIndex = 1;
            this.buttonTambahEvent.Text = "Tambah";
            this.buttonTambahEvent.UseVisualStyleBackColor = false;
            this.buttonTambahEvent.Click += new System.EventHandler(this.buttonTambahEvent_Click);
            // 
            // comboBoxPage
            // 
            this.comboBoxPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPage.FormattingEnabled = true;
            this.comboBoxPage.Location = new System.Drawing.Point(13, 477);
            this.comboBoxPage.Name = "comboBoxPage";
            this.comboBoxPage.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPage.TabIndex = 2;
            this.comboBoxPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxPage_SelectedIndexChanged);
            // 
            // buttonLihatPeserta
            // 
            this.buttonLihatPeserta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonLihatPeserta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatPeserta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatPeserta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatPeserta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatPeserta.Location = new System.Drawing.Point(168, 400);
            this.buttonLihatPeserta.Name = "buttonLihatPeserta";
            this.buttonLihatPeserta.Size = new System.Drawing.Size(150, 53);
            this.buttonLihatPeserta.TabIndex = 3;
            this.buttonLihatPeserta.Text = "Lihat Peserta";
            this.buttonLihatPeserta.UseVisualStyleBackColor = false;
            this.buttonLihatPeserta.Click += new System.EventHandler(this.buttonLihatPeserta_Click);
            // 
            // buttonLihatHasil
            // 
            this.buttonLihatHasil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonLihatHasil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatHasil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatHasil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatHasil.Location = new System.Drawing.Point(349, 400);
            this.buttonLihatHasil.Name = "buttonLihatHasil";
            this.buttonLihatHasil.Size = new System.Drawing.Size(130, 53);
            this.buttonLihatHasil.TabIndex = 4;
            this.buttonLihatHasil.Text = "Lihat Hasil";
            this.buttonLihatHasil.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(512, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EventPageShowPageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLihatHasil);
            this.Controls.Add(this.buttonLihatPeserta);
            this.Controls.Add(this.comboBoxPage);
            this.Controls.Add(this.buttonTambahEvent);
            this.Controls.Add(this.dataGridView);
            this.Name = "EventPageShowPageDetails";
            this.Size = new System.Drawing.Size(951, 532);
            this.Load += new System.EventHandler(this.EventPageShowPageDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonTambahEvent;
        private System.Windows.Forms.ComboBox comboBoxPage;
        private System.Windows.Forms.Button buttonLihatPeserta;
        private System.Windows.Forms.Button buttonLihatHasil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventStatus;
    }
}
