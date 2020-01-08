namespace UAS {
    partial class EventPage {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonParticipantPage = new System.Windows.Forms.Button();
            this.buttonEventPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.participantPageShowPageDetails1 = new UAS.Page.ParticipantPageShowPageDetails();
            this.eventPageShowPageDetails1 = new UAS.Page.EventPageShowPageDetails();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonParticipantPage);
            this.panel1.Controls.Add(this.buttonEventPage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 656);
            this.panel1.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(-3, 238);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.buttonLogout.Size = new System.Drawing.Size(250, 67);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonParticipantPage
            // 
            this.buttonParticipantPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.buttonParticipantPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonParticipantPage.FlatAppearance.BorderSize = 0;
            this.buttonParticipantPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParticipantPage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParticipantPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonParticipantPage.Location = new System.Drawing.Point(1, 173);
            this.buttonParticipantPage.Name = "buttonParticipantPage";
            this.buttonParticipantPage.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.buttonParticipantPage.Size = new System.Drawing.Size(250, 67);
            this.buttonParticipantPage.TabIndex = 1;
            this.buttonParticipantPage.Text = "Participant";
            this.buttonParticipantPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParticipantPage.UseVisualStyleBackColor = false;
            this.buttonParticipantPage.Click += new System.EventHandler(this.buttonParticipantPage_Click);
            // 
            // buttonEventPage
            // 
            this.buttonEventPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(61)))));
            this.buttonEventPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventPage.FlatAppearance.BorderSize = 0;
            this.buttonEventPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventPage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEventPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventPage.Location = new System.Drawing.Point(1, 108);
            this.buttonEventPage.Name = "buttonEventPage";
            this.buttonEventPage.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.buttonEventPage.Size = new System.Drawing.Size(250, 67);
            this.buttonEventPage.TabIndex = 0;
            this.buttonEventPage.Text = "Event";
            this.buttonEventPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventPage.UseVisualStyleBackColor = false;
            this.buttonEventPage.Click += new System.EventHandler(this.buttonEventPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Location = new System.Drawing.Point(253, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 56);
            this.panel2.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(23, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(80, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Event";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.participantPageShowPageDetails1);
            this.panel3.Controls.Add(this.eventPageShowPageDetails1);
            this.panel3.Location = new System.Drawing.Point(254, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 600);
            this.panel3.TabIndex = 3;
            // 
            // participantPageShowPageDetails1
            // 
            this.participantPageShowPageDetails1.Location = new System.Drawing.Point(-1, -1);
            this.participantPageShowPageDetails1.Name = "participantPageShowPageDetails1";
            this.participantPageShowPageDetails1.Size = new System.Drawing.Size(953, 601);
            this.participantPageShowPageDetails1.TabIndex = 1;
            // 
            // eventPageShowPageDetails1
            // 
            this.eventPageShowPageDetails1.Location = new System.Drawing.Point(1, -1);
            this.eventPageShowPageDetails1.Name = "eventPageShowPageDetails1";
            this.eventPageShowPageDetails1.Size = new System.Drawing.Size(951, 532);
            this.eventPageShowPageDetails1.TabIndex = 0;
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventPage";
            this.Size = new System.Drawing.Size(1204, 659);
            this.Load += new System.EventHandler(this.EventPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEventPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonParticipantPage;
        private System.Windows.Forms.Panel panel3;
        private Page.ParticipantPageShowPageDetails participantPageShowPageDetails1;
        private Page.EventPageShowPageDetails eventPageShowPageDetails1;
    }
}
