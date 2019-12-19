namespace UAS.FormPage.Schedule {
    partial class RoundForm {
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
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleRound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditRonde = new System.Windows.Forms.Button();
            this.buttonLihatRonde = new System.Windows.Forms.Button();
            this.buttonTambahRonde = new System.Windows.Forms.Button();
            this.buttonDeleteRound = new System.Windows.Forms.Button();
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
            this.ColumnNumber,
            this.ScheduleRound,
            this.EventType,
            this.EventName});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(849, 402);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "No";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            // 
            // ScheduleRound
            // 
            this.ScheduleRound.HeaderText = "Round";
            this.ScheduleRound.MinimumWidth = 6;
            this.ScheduleRound.Name = "ScheduleRound";
            // 
            // EventType
            // 
            this.EventType.HeaderText = "Tipe";
            this.EventType.MinimumWidth = 6;
            this.EventType.Name = "EventType";
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Nama";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            // 
            // buttonEditRonde
            // 
            this.buttonEditRonde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditRonde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditRonde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRonde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRonde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditRonde.Location = new System.Drawing.Point(463, 444);
            this.buttonEditRonde.Name = "buttonEditRonde";
            this.buttonEditRonde.Size = new System.Drawing.Size(150, 53);
            this.buttonEditRonde.TabIndex = 7;
            this.buttonEditRonde.Text = "Edit Ronde";
            this.buttonEditRonde.UseVisualStyleBackColor = false;
            this.buttonEditRonde.Click += new System.EventHandler(this.buttonEditRonde_Click);
            // 
            // buttonLihatRonde
            // 
            this.buttonLihatRonde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonLihatRonde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLihatRonde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLihatRonde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatRonde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLihatRonde.Location = new System.Drawing.Point(258, 444);
            this.buttonLihatRonde.Name = "buttonLihatRonde";
            this.buttonLihatRonde.Size = new System.Drawing.Size(150, 53);
            this.buttonLihatRonde.TabIndex = 6;
            this.buttonLihatRonde.Text = "Lihat Ronde";
            this.buttonLihatRonde.UseVisualStyleBackColor = false;
            this.buttonLihatRonde.Click += new System.EventHandler(this.buttonLihatRonde_Click);
            // 
            // buttonTambahRonde
            // 
            this.buttonTambahRonde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahRonde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahRonde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahRonde.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahRonde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahRonde.Location = new System.Drawing.Point(40, 444);
            this.buttonTambahRonde.Name = "buttonTambahRonde";
            this.buttonTambahRonde.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahRonde.TabIndex = 5;
            this.buttonTambahRonde.Text = "Tambah Ronde";
            this.buttonTambahRonde.UseVisualStyleBackColor = false;
            this.buttonTambahRonde.Click += new System.EventHandler(this.buttonTambahRonde_Click);
            // 
            // buttonDeleteRound
            // 
            this.buttonDeleteRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDeleteRound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRound.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteRound.Location = new System.Drawing.Point(668, 444);
            this.buttonDeleteRound.Name = "buttonDeleteRound";
            this.buttonDeleteRound.Size = new System.Drawing.Size(150, 53);
            this.buttonDeleteRound.TabIndex = 8;
            this.buttonDeleteRound.Text = "Hapus Ronde";
            this.buttonDeleteRound.UseVisualStyleBackColor = false;
            this.buttonDeleteRound.Click += new System.EventHandler(this.buttonDeleteRound_Click);
            // 
            // RoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 545);
            this.Controls.Add(this.buttonDeleteRound);
            this.Controls.Add(this.buttonEditRonde);
            this.Controls.Add(this.buttonLihatRonde);
            this.Controls.Add(this.buttonTambahRonde);
            this.Controls.Add(this.dataGridView);
            this.Name = "RoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round";
            this.Load += new System.EventHandler(this.RoundForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonEditRonde;
        private System.Windows.Forms.Button buttonLihatRonde;
        private System.Windows.Forms.Button buttonTambahRonde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleRound;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.Button buttonDeleteRound;
    }
}