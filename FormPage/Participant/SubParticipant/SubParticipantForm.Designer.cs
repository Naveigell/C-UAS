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
            this.buttonTambahPeserta = new System.Windows.Forms.Button();
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
            this.SubParticipantName,
            this.SubParticipantAddress,
            this.SubParticipantBirthday,
            this.SubParticipantGender});
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
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
            this.buttonDeleteParticipant.Location = new System.Drawing.Point(217, 466);
            this.buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            this.buttonDeleteParticipant.Size = new System.Drawing.Size(150, 53);
            this.buttonDeleteParticipant.TabIndex = 8;
            this.buttonDeleteParticipant.Text = "Hapus Peserta";
            this.buttonDeleteParticipant.UseVisualStyleBackColor = false;
            this.buttonDeleteParticipant.Click += new System.EventHandler(this.buttonDeleteParticipant_Click);
            // 
            // buttonTambahPeserta
            // 
            this.buttonTambahPeserta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahPeserta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahPeserta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahPeserta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahPeserta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahPeserta.Location = new System.Drawing.Point(20, 466);
            this.buttonTambahPeserta.Name = "buttonTambahPeserta";
            this.buttonTambahPeserta.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahPeserta.TabIndex = 6;
            this.buttonTambahPeserta.Text = "Tambah Peserta";
            this.buttonTambahPeserta.UseVisualStyleBackColor = false;
            this.buttonTambahPeserta.Click += new System.EventHandler(this.buttonTambahPeserta_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 27);
            this.toolStrip1.TabIndex = 16;
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
            // SubParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 542);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonDeleteParticipant);
            this.Controls.Add(this.buttonTambahPeserta);
            this.Controls.Add(this.dataGridView);
            this.Name = "SubParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubParticipantForm";
            this.Load += new System.EventHandler(this.SubParticipantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubParticipantGender;
        private System.Windows.Forms.Button buttonDeleteParticipant;
        private System.Windows.Forms.Button buttonTambahPeserta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonPrint;
    }
}