namespace UAS.FormPage.Schedule.Versus {
    partial class VersusEvent {
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
            this.ParticipantName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteVersus = new System.Windows.Forms.Button();
            this.buttonEditJadwalPesertaVersus = new System.Windows.Forms.Button();
            this.buttonTambahJadwalVersus = new System.Windows.Forms.Button();
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
            this.ParticipantName1,
            this.vs,
            this.ParticipantName2,
            this.EventStartDate,
            this.Score,
            this.Venue});
            this.dataGridView.Location = new System.Drawing.Point(13, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(846, 360);
            this.dataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ParticipantName1
            // 
            this.ParticipantName1.HeaderText = "Nama Peserta";
            this.ParticipantName1.MinimumWidth = 6;
            this.ParticipantName1.Name = "ParticipantName1";
            this.ParticipantName1.ReadOnly = true;
            // 
            // vs
            // 
            this.vs.HeaderText = "";
            this.vs.MinimumWidth = 6;
            this.vs.Name = "vs";
            this.vs.ReadOnly = true;
            // 
            // ParticipantName2
            // 
            this.ParticipantName2.HeaderText = "Nama Peserta";
            this.ParticipantName2.MinimumWidth = 6;
            this.ParticipantName2.Name = "ParticipantName2";
            this.ParticipantName2.ReadOnly = true;
            // 
            // EventStartDate
            // 
            this.EventStartDate.HeaderText = "Waktu Pelaksanaan";
            this.EventStartDate.MinimumWidth = 6;
            this.EventStartDate.Name = "EventStartDate";
            this.EventStartDate.ReadOnly = true;
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
            // buttonDeleteVersus
            // 
            this.buttonDeleteVersus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDeleteVersus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteVersus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVersus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteVersus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteVersus.Location = new System.Drawing.Point(428, 425);
            this.buttonDeleteVersus.Name = "buttonDeleteVersus";
            this.buttonDeleteVersus.Size = new System.Drawing.Size(150, 53);
            this.buttonDeleteVersus.TabIndex = 11;
            this.buttonDeleteVersus.Text = "Hapus Jadwal";
            this.buttonDeleteVersus.UseVisualStyleBackColor = false;
            this.buttonDeleteVersus.Click += new System.EventHandler(this.buttonDeleteVersus_Click);
            // 
            // buttonEditJadwalPesertaVersus
            // 
            this.buttonEditJadwalPesertaVersus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditJadwalPesertaVersus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditJadwalPesertaVersus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditJadwalPesertaVersus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditJadwalPesertaVersus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditJadwalPesertaVersus.Location = new System.Drawing.Point(239, 425);
            this.buttonEditJadwalPesertaVersus.Name = "buttonEditJadwalPesertaVersus";
            this.buttonEditJadwalPesertaVersus.Size = new System.Drawing.Size(150, 53);
            this.buttonEditJadwalPesertaVersus.TabIndex = 10;
            this.buttonEditJadwalPesertaVersus.Text = "Edit Jadwal";
            this.buttonEditJadwalPesertaVersus.UseVisualStyleBackColor = false;
            this.buttonEditJadwalPesertaVersus.Click += new System.EventHandler(this.buttonEditJadwalPesertaVersus_Click);
            // 
            // buttonTambahJadwalVersus
            // 
            this.buttonTambahJadwalVersus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahJadwalVersus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahJadwalVersus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahJadwalVersus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahJadwalVersus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahJadwalVersus.Location = new System.Drawing.Point(29, 425);
            this.buttonTambahJadwalVersus.Name = "buttonTambahJadwalVersus";
            this.buttonTambahJadwalVersus.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahJadwalVersus.TabIndex = 9;
            this.buttonTambahJadwalVersus.Text = "Tambah Jadwal";
            this.buttonTambahJadwalVersus.UseVisualStyleBackColor = false;
            this.buttonTambahJadwalVersus.Click += new System.EventHandler(this.buttonTambahJadwalVersus_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonPrint
            // 
            this.buttonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrint.Image = global::UAS.Properties.Resources.Print_48px;
            this.buttonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(29, 24);
            this.buttonPrint.Text = "Print";
            this.buttonPrint.ToolTipText = "Print";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // VersusEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 553);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonDeleteVersus);
            this.Controls.Add(this.buttonEditJadwalPesertaVersus);
            this.Controls.Add(this.buttonTambahJadwalVersus);
            this.Controls.Add(this.dataGridView);
            this.Name = "VersusEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VersusEvent";
            this.Load += new System.EventHandler(this.VersusEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.Button buttonDeleteVersus;
        private System.Windows.Forms.Button buttonEditJadwalPesertaVersus;
        private System.Windows.Forms.Button buttonTambahJadwalVersus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonPrint;
    }
}