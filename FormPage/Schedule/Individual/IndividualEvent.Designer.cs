namespace UAS.FormPage.Schedule {
    partial class IndividualEvent {
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
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndividualScheduleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditJadwalPesertaIndividual = new System.Windows.Forms.Button();
            this.buttonTambahJadwalPeserta = new System.Windows.Forms.Button();
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
            this.No,
            this.IndividualScheduleName,
            this.Time,
            this.Score,
            this.Venue});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(904, 421);
            this.dataGridView.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // IndividualScheduleName
            // 
            this.IndividualScheduleName.HeaderText = "Nama Peserta";
            this.IndividualScheduleName.MinimumWidth = 6;
            this.IndividualScheduleName.Name = "IndividualScheduleName";
            this.IndividualScheduleName.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Waktu Pelaksanaan";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Skor";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.MinimumWidth = 6;
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            // 
            // buttonEditJadwalPesertaIndividual
            // 
            this.buttonEditJadwalPesertaIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditJadwalPesertaIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditJadwalPesertaIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditJadwalPesertaIndividual.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditJadwalPesertaIndividual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditJadwalPesertaIndividual.Location = new System.Drawing.Point(231, 472);
            this.buttonEditJadwalPesertaIndividual.Name = "buttonEditJadwalPesertaIndividual";
            this.buttonEditJadwalPesertaIndividual.Size = new System.Drawing.Size(150, 53);
            this.buttonEditJadwalPesertaIndividual.TabIndex = 7;
            this.buttonEditJadwalPesertaIndividual.Text = "Edit Jadwal";
            this.buttonEditJadwalPesertaIndividual.UseVisualStyleBackColor = false;
            this.buttonEditJadwalPesertaIndividual.Click += new System.EventHandler(this.buttonEditJadwalPesertaIndividual_Click);
            // 
            // buttonTambahJadwalPeserta
            // 
            this.buttonTambahJadwalPeserta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahJadwalPeserta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahJadwalPeserta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahJadwalPeserta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahJadwalPeserta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahJadwalPeserta.Location = new System.Drawing.Point(21, 472);
            this.buttonTambahJadwalPeserta.Name = "buttonTambahJadwalPeserta";
            this.buttonTambahJadwalPeserta.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahJadwalPeserta.TabIndex = 5;
            this.buttonTambahJadwalPeserta.Text = "Tambah Jadwal";
            this.buttonTambahJadwalPeserta.UseVisualStyleBackColor = false;
            this.buttonTambahJadwalPeserta.Click += new System.EventHandler(this.buttonTambahJadwalPeserta_Click);
            // 
            // IndividualEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 583);
            this.Controls.Add(this.buttonEditJadwalPesertaIndividual);
            this.Controls.Add(this.buttonTambahJadwalPeserta);
            this.Controls.Add(this.dataGridView);
            this.Name = "IndividualEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndividualEvent";
            this.Load += new System.EventHandler(this.IndividualEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndividualScheduleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.Button buttonEditJadwalPesertaIndividual;
        private System.Windows.Forms.Button buttonTambahJadwalPeserta;
    }
}