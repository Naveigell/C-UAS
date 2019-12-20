namespace UAS.FormPage.Participant.SubParticipant {
    partial class SubParticipantForm {
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
            this.SubParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubParticipantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubParticipantBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubParticipantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteParticipant = new System.Windows.Forms.Button();
            this.buttonEditParticipant = new System.Windows.Forms.Button();
            this.buttonTambahPeserta = new System.Windows.Forms.Button();
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
            this.SubParticipantName,
            this.SubParticipantAddress,
            this.SubParticipantBirthday,
            this.SubParticipantGender});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(817, 402);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // SubParticipantName
            // 
            this.SubParticipantName.HeaderText = "Nama";
            this.SubParticipantName.MinimumWidth = 6;
            this.SubParticipantName.Name = "SubParticipantName";
            // 
            // SubParticipantAddress
            // 
            this.SubParticipantAddress.HeaderText = "Alamat";
            this.SubParticipantAddress.MinimumWidth = 6;
            this.SubParticipantAddress.Name = "SubParticipantAddress";
            // 
            // SubParticipantBirthday
            // 
            this.SubParticipantBirthday.HeaderText = "Tanggal lahir";
            this.SubParticipantBirthday.MinimumWidth = 6;
            this.SubParticipantBirthday.Name = "SubParticipantBirthday";
            // 
            // SubParticipantGender
            // 
            this.SubParticipantGender.HeaderText = "Jenis kelamin";
            this.SubParticipantGender.MinimumWidth = 6;
            this.SubParticipantGender.Name = "SubParticipantGender";
            // 
            // buttonDeleteParticipant
            // 
            this.buttonDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDeleteParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteParticipant.Location = new System.Drawing.Point(451, 448);
            this.buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            this.buttonDeleteParticipant.Size = new System.Drawing.Size(150, 53);
            this.buttonDeleteParticipant.TabIndex = 8;
            this.buttonDeleteParticipant.Text = "Hapus Peserta";
            this.buttonDeleteParticipant.UseVisualStyleBackColor = false;
            this.buttonDeleteParticipant.Click += new System.EventHandler(this.buttonDeleteParticipant_Click);
            // 
            // buttonEditParticipant
            // 
            this.buttonEditParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditParticipant.Location = new System.Drawing.Point(245, 448);
            this.buttonEditParticipant.Name = "buttonEditParticipant";
            this.buttonEditParticipant.Size = new System.Drawing.Size(150, 53);
            this.buttonEditParticipant.TabIndex = 7;
            this.buttonEditParticipant.Text = "Edit Peserta";
            this.buttonEditParticipant.UseVisualStyleBackColor = false;
            this.buttonEditParticipant.Click += new System.EventHandler(this.buttonEditParticipant_Click);
            // 
            // buttonTambahPeserta
            // 
            this.buttonTambahPeserta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahPeserta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahPeserta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahPeserta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahPeserta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahPeserta.Location = new System.Drawing.Point(20, 448);
            this.buttonTambahPeserta.Name = "buttonTambahPeserta";
            this.buttonTambahPeserta.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahPeserta.TabIndex = 6;
            this.buttonTambahPeserta.Text = "Tambah Peserta";
            this.buttonTambahPeserta.UseVisualStyleBackColor = false;
            this.buttonTambahPeserta.Click += new System.EventHandler(this.buttonTambahPeserta_Click);
            // 
            // SubParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 542);
            this.Controls.Add(this.buttonDeleteParticipant);
            this.Controls.Add(this.buttonEditParticipant);
            this.Controls.Add(this.buttonTambahPeserta);
            this.Controls.Add(this.dataGridView);
            this.Name = "SubParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubParticipantForm";
            this.Load += new System.EventHandler(this.SubParticipantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantGender;
        private System.Windows.Forms.Button buttonDeleteParticipant;
        private System.Windows.Forms.Button buttonEditParticipant;
        private System.Windows.Forms.Button buttonTambahPeserta;
    }
}