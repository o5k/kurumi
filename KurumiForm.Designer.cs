namespace Kurumi {
    partial class KurumiForm {
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
            this.activityIcon = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.ownClock = new System.Windows.Forms.Label();
            this.lblOT = new System.Windows.Forms.Label();
            this.serverClock = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.Difference = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.oskLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.activityIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // activityIcon
            // 
            this.activityIcon.Image = global::Kurumi.Properties.Resources.waiting;
            this.activityIcon.Location = new System.Drawing.Point(13, 13);
            this.activityIcon.Name = "activityIcon";
            this.activityIcon.Size = new System.Drawing.Size(32, 32);
            this.activityIcon.TabIndex = 0;
            this.activityIcon.TabStop = false;
            // 
            // topLabel
            // 
            this.topLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLabel.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(52, 17);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(524, 28);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Obtaining network time...";
            // 
            // ownClock
            // 
            this.ownClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownClock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ownClock.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownClock.Location = new System.Drawing.Point(56, 49);
            this.ownClock.Name = "ownClock";
            this.ownClock.Size = new System.Drawing.Size(520, 51);
            this.ownClock.TabIndex = 2;
            this.ownClock.Text = "00:00:00";
            this.ownClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOT
            // 
            this.lblOT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOT.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOT.Location = new System.Drawing.Point(56, 100);
            this.lblOT.Name = "lblOT";
            this.lblOT.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblOT.Size = new System.Drawing.Size(116, 27);
            this.lblOT.TabIndex = 3;
            this.lblOT.Text = "Own time";
            // 
            // serverClock
            // 
            this.serverClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverClock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.serverClock.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverClock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serverClock.Location = new System.Drawing.Point(56, 131);
            this.serverClock.Name = "serverClock";
            this.serverClock.Size = new System.Drawing.Size(520, 51);
            this.serverClock.TabIndex = 4;
            this.serverClock.Text = "Obtaining...";
            this.serverClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblST
            // 
            this.lblST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblST.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblST.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblST.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblST.Location = new System.Drawing.Point(460, 104);
            this.lblST.Name = "lblST";
            this.lblST.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.lblST.Size = new System.Drawing.Size(116, 27);
            this.lblST.TabIndex = 5;
            this.lblST.Text = "Network time";
            this.lblST.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Difference
            // 
            this.Difference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Difference.BackColor = System.Drawing.SystemColors.Highlight;
            this.Difference.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difference.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Difference.Location = new System.Drawing.Point(176, 104);
            this.Difference.Name = "Difference";
            this.Difference.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Difference.Size = new System.Drawing.Size(280, 23);
            this.Difference.TabIndex = 6;
            this.Difference.Text = "Obtaining...";
            this.Difference.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(279, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFix.Enabled = false;
            this.btnFix.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(298, 196);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(278, 41);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "&Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // oskLink
            // 
            this.oskLink.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.oskLink.AutoSize = true;
            this.oskLink.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oskLink.LinkColor = System.Drawing.SystemColors.Highlight;
            this.oskLink.Location = new System.Drawing.Point(16, 171);
            this.oskLink.Name = "oskLink";
            this.oskLink.Size = new System.Drawing.Size(34, 11);
            this.oskLink.TabIndex = 9;
            this.oskLink.TabStop = true;
            this.oskLink.Text = "osk.sh";
            this.oskLink.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.oskLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.oskLink_LinkClicked);
            // 
            // KurumiForm
            // 
            this.AcceptButton = this.btnFix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(588, 249);
            this.Controls.Add(this.oskLink);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.lblST);
            this.Controls.Add(this.serverClock);
            this.Controls.Add(this.lblOT);
            this.Controls.Add(this.ownClock);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.activityIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KurumiForm";
            this.Text = "Kurumi by osk";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KurumiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox activityIcon;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label ownClock;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.Label serverClock;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Label Difference;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.LinkLabel oskLink;
    }
}