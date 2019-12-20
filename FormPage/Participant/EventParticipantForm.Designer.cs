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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantCellularPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTambahPeserta = new System.Windows.Forms.Button();
            this.buttonLihatJadwal = new System.Windows.Forms.Button();
            this.buttonEditParticipant = new System.Windows.Forms.Button();
            this.buttonDeleteParticipant = new System.Windows.Forms.Button();
            this.buttonLihatAnggota = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(2, 44);
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
            // buttonTambahPeserta
            // 
            this.buttonTambahPeserta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahPeserta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahPeserta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahPeserta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahPeserta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahPeserta.Location = new System.Drawing.Point(33, 501);
            this.buttonTambahPeserta.Name = "buttonTambahPeserta";
            this.buttonTambahPeserta.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahPeserta.TabIndex = 2;
            this.buttonTambahPeserta.Text = "Tambah Peserta";
            this.buttonTambahPeserta.UseVisualStyleBackColor = false;
            this.buttonTambahPeserta.Click += new System.EventHandler(this.buttonTambahPeserta_Click);
            // 
            // buttonLihatJadwal
            // 
            this.buttonLihatJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonLihatJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatJadwal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatJadwal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatJadwal.Location = new System.Drawing.Point(251, 501);
            this.buttonLihatJadwal.Name = "buttonLihatJadwal";
            this.buttonLihatJadwal.Size = new System.Drawing.Size(150, 53);
            this.buttonLihatJadwal.TabIndex = 3;
            this.buttonLihatJadwal.Text = "Lihat Jadwal";
            this.buttonLihatJadwal.UseVisualStyleBackColor = false;
            this.buttonLihatJadwal.Click += new System.EventHandler(this.buttonLihatJadwal_Click);
            // 
            // buttonEditParticipant
            // 
            this.buttonEditParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditParticipant.Location = new System.Drawing.Point(456, 501);
            this.buttonEditParticipant.Name = "buttonEditParticipant";
            this.buttonEditParticipant.Size = new System.Drawing.Size(150, 53);
            this.buttonEditParticipant.TabIndex = 4;
            this.buttonEditParticipant.Text = "Edit Peserta";
            this.buttonEditParticipant.UseVisualStyleBackColor = false;
            this.buttonEditParticipant.Click += new System.EventHandler(this.buttonEditParticipant_Click);
            // 
            // buttonDeleteParticipant
            // 
            this.buttonDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDeleteParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteParticipant.Location = new System.Drawing.Point(662, 501);
            this.buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            this.buttonDeleteParticipant.Size = new System.Drawing.Size(150, 53);
            this.buttonDeleteParticipant.TabIndex = 5;
            this.buttonDeleteParticipant.Text = "Hapus Peserta";
            this.buttonDeleteParticipant.UseVisualStyleBackColor = false;
            this.buttonDeleteParticipant.Click += new System.EventHandler(this.buttonDeleteParticipant_Click);
            // 
            // buttonLihatAnggota
            // 
            this.buttonLihatAnggota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonLihatAnggota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatAnggota.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatAnggota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatAnggota.Location = new System.Drawing.Point(871, 501);
            this.buttonLihatAnggota.Name = "buttonLihatAnggota";
            this.buttonLihatAnggota.Size = new System.Drawing.Size(160, 53);
            this.buttonLihatAnggota.TabIndex = 6;
            this.buttonLihatAnggota.Text = "Lihat Anggota";
            this.buttonLihatAnggota.UseVisualStyleBackColor = false;
            this.buttonLihatAnggota.Click += new System.EventHandler(this.buttonLihatAnggota_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1099, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonPrint
            // 
            this.buttonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrint.Image = global::UAS.Properties.Resources.Print_48px;
            this.buttonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(29, 28);
            this.buttonPrint.Text = "Print";
            this.buttonPrint.ToolTipText = "Print";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // EventParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 580);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonLihatAnggota);
            this.Controls.Add(this.buttonDeleteParticipant);
            this.Controls.Add(this.buttonEditParticipant);
            this.Controls.Add(this.buttonLihatJadwal);
            this.Controls.Add(this.buttonTambahPeserta);
            this.Controls.Add(this.dataGridView);
            this.Name = "EventParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant";
            this.Load += new System.EventHandler(this.EventParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantCellularPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantGender;
        private System.Windows.Forms.Button buttonTambahPeserta;
        private System.Windows.Forms.Button buttonLihatJadwal;
        private System.Windows.Forms.Button buttonEditParticipant;
        private System.Windows.Forms.Button buttonDeleteParticipant;
        private System.Windows.Forms.Button buttonLihatAnggota;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonPrint;
    }
}