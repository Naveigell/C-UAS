namespace UAS.FormPage.Schedule.Individual {
    partial class EditIndividualForm {
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonEditSchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEventVenue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Skor :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 1);
            this.panel2.TabIndex = 55;
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.textBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxScore.Location = new System.Drawing.Point(27, 108);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(495, 20);
            this.textBoxScore.TabIndex = 54;
            // 
            // buttonEditSchedule
            // 
            this.buttonEditSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(61)))));
            this.buttonEditSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditSchedule.FlatAppearance.BorderSize = 0;
            this.buttonEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSchedule.Location = new System.Drawing.Point(27, 241);
            this.buttonEditSchedule.Name = "buttonEditSchedule";
            this.buttonEditSchedule.Size = new System.Drawing.Size(495, 40);
            this.buttonEditSchedule.TabIndex = 53;
            this.buttonEditSchedule.Text = "Simpan";
            this.buttonEditSchedule.UseVisualStyleBackColor = false;
            this.buttonEditSchedule.Click += new System.EventHandler(this.buttonEditSchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Venue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 1);
            this.panel1.TabIndex = 47;
            // 
            // textBoxEventVenue
            // 
            this.textBoxEventVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.textBoxEventVenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEventVenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventVenue.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEventVenue.Location = new System.Drawing.Point(26, 177);
            this.textBoxEventVenue.Name = "textBoxEventVenue";
            this.textBoxEventVenue.Size = new System.Drawing.Size(495, 20);
            this.textBoxEventVenue.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 45;
            this.label1.Text = "Edit jadwal";
            // 
            // EditIndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(555, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.buttonEditSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEventVenue);
            this.Controls.Add(this.label1);
            this.Name = "EditIndividualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditIndividualForm";
            this.Load += new System.EventHandler(this.EditIndividualForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonEditSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEventVenue;
        private System.Windows.Forms.Label label1;
    }
}