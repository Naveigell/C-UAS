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
            this.buttonHomePage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eventPageShowPageDetails = new UAS.Page.EventPageShowPageDetails();
            this.buttonEventPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonEventPage);
            this.panel1.Controls.Add(this.buttonHomePage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 656);
            this.panel1.TabIndex = 1;
            // 
            // buttonHomePage
            // 
            this.buttonHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(61)))));
            this.buttonHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHomePage.FlatAppearance.BorderSize = 0;
            this.buttonHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomePage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomePage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHomePage.Location = new System.Drawing.Point(1, 108);
            this.buttonHomePage.Name = "buttonHomePage";
            this.buttonHomePage.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.buttonHomePage.Size = new System.Drawing.Size(250, 67);
            this.buttonHomePage.TabIndex = 0;
            this.buttonHomePage.Text = "Event";
            this.buttonHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHomePage.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(253, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 56);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event";
            // 
            // eventPageShowPageDetails
            // 
            this.eventPageShowPageDetails.Location = new System.Drawing.Point(253, 59);
            this.eventPageShowPageDetails.Name = "eventPageShowPageDetails";
            this.eventPageShowPageDetails.Size = new System.Drawing.Size(951, 540);
            this.eventPageShowPageDetails.TabIndex = 3;
            this.eventPageShowPageDetails.Load += new System.EventHandler(this.eventPageShowPageDetails1_Load);
            // 
            // buttonEventPage
            // 
            this.buttonEventPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.buttonEventPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventPage.FlatAppearance.BorderSize = 0;
            this.buttonEventPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventPage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEventPage.Location = new System.Drawing.Point(1, 173);
            this.buttonEventPage.Name = "buttonEventPage";
            this.buttonEventPage.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.buttonEventPage.Size = new System.Drawing.Size(250, 67);
            this.buttonEventPage.TabIndex = 1;
            this.buttonEventPage.Text = "Profile";
            this.buttonEventPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventPage.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-3, 238);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(45, 0, 0, 4);
            this.button1.Size = new System.Drawing.Size(250, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventPageShowPageDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventPage";
            this.Size = new System.Drawing.Size(1204, 659);
            this.Load += new System.EventHandler(this.EventPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHomePage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Page.EventPageShowPageDetails eventPageShowPageDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEventPage;
    }
}
