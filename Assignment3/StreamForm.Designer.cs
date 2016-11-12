namespace Assignment3
{
    partial class StreamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.CCAuthLabel = new System.Windows.Forms.Label();
            this.MovieStreamNotificationLabel = new System.Windows.Forms.Label();
            this.OkayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Location = new System.Drawing.Point(82, 27);
            this.ThankYouLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(352, 23);
            this.ThankYouLabel.TabIndex = 0;
            this.ThankYouLabel.Text = "Thank you for using Movie Bonanza!";
            // 
            // CCAuthLabel
            // 
            this.CCAuthLabel.Location = new System.Drawing.Point(12, 61);
            this.CCAuthLabel.Name = "CCAuthLabel";
            this.CCAuthLabel.Size = new System.Drawing.Size(492, 23);
            this.CCAuthLabel.TabIndex = 1;
            this.CCAuthLabel.Text = "Your credit card has been charged $x.xx";
            this.CCAuthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieStreamNotificationLabel
            // 
            this.MovieStreamNotificationLabel.Location = new System.Drawing.Point(12, 95);
            this.MovieStreamNotificationLabel.MaximumSize = new System.Drawing.Size(492, 46);
            this.MovieStreamNotificationLabel.Name = "MovieStreamNotificationLabel";
            this.MovieStreamNotificationLabel.Size = new System.Drawing.Size(492, 46);
            this.MovieStreamNotificationLabel.TabIndex = 2;
            this.MovieStreamNotificationLabel.Text = "<Movie Name> will begin streaming now.";
            this.MovieStreamNotificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(226, 150);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(64, 35);
            this.OkayButton.TabIndex = 3;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // StreamForm
            // 
            this.AcceptButton = this.OkayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 197);
            this.ControlBox = false;
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.MovieStreamNotificationLabel);
            this.Controls.Add(this.CCAuthLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label CCAuthLabel;
        private System.Windows.Forms.Label MovieStreamNotificationLabel;
        private System.Windows.Forms.Button OkayButton;
    }
}