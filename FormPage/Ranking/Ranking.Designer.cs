namespace UAS.FormPage {
    partial class Ranking {
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
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteRangking = new System.Windows.Forms.Button();
            this.buttonEditRangking = new System.Windows.Forms.Button();
            this.buttonTambahRanking = new System.Windows.Forms.Button();
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
            this.Rank,
            this.EventName,
            this.ParticipantName,
            this.TotalScore});
            this.dataGridView.Location = new System.Drawing.Point(13, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(789, 339);
            this.dataGridView.TabIndex = 0;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Ranking";
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "Nama Peserta";
            this.ParticipantName.MinimumWidth = 6;
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            // 
            // TotalScore
            // 
            this.TotalScore.HeaderText = "Score";
            this.TotalScore.MinimumWidth = 6;
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.ReadOnly = true;
            // 
            // buttonDeleteRangking
            // 
            this.buttonDeleteRangking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDeleteRangking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteRangking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRangking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRangking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteRangking.Location = new System.Drawing.Point(423, 408);
            this.buttonDeleteRangking.Name = "buttonDeleteRangking";
            this.buttonDeleteRangking.Size = new System.Drawing.Size(180, 53);
            this.buttonDeleteRangking.TabIndex = 14;
            this.buttonDeleteRangking.Text = "Hapus Ranking";
            this.buttonDeleteRangking.UseVisualStyleBackColor = false;
            this.buttonDeleteRangking.Click += new System.EventHandler(this.buttonDeleteRangking_Click);
            // 
            // buttonEditRangking
            // 
            this.buttonEditRangking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonEditRangking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditRangking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRangking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRangking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditRangking.Location = new System.Drawing.Point(234, 408);
            this.buttonEditRangking.Name = "buttonEditRangking";
            this.buttonEditRangking.Size = new System.Drawing.Size(150, 53);
            this.buttonEditRangking.TabIndex = 13;
            this.buttonEditRangking.Text = "Edit Ranking";
            this.buttonEditRangking.UseVisualStyleBackColor = false;
            this.buttonEditRangking.Click += new System.EventHandler(this.buttonEditRangking_Click);
            // 
            // buttonTambahRanking
            // 
            this.buttonTambahRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonTambahRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahRanking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahRanking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTambahRanking.Location = new System.Drawing.Point(24, 408);
            this.buttonTambahRanking.Name = "buttonTambahRanking";
            this.buttonTambahRanking.Size = new System.Drawing.Size(170, 53);
            this.buttonTambahRanking.TabIndex = 12;
            this.buttonTambahRanking.Text = "Tambah Ranking";
            this.buttonTambahRanking.UseVisualStyleBackColor = false;
            this.buttonTambahRanking.Click += new System.EventHandler(this.buttonTambahRanking_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 27);
            this.toolStrip1.TabIndex = 15;
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
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 487);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonDeleteRangking);
            this.Controls.Add(this.buttonEditRangking);
            this.Controls.Add(this.buttonTambahRanking);
            this.Controls.Add(this.dataGridView);
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteRangking;
        private System.Windows.Forms.Button buttonEditRangking;
        private System.Windows.Forms.Button buttonTambahRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonPrint;
    }
}