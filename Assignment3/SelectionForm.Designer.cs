namespace Assignment3
{
    partial class SelectionForm
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
            this.MovieComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MoviePriceTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieComboBox
            // 
            this.MovieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieComboBox.Location = new System.Drawing.Point(15, 169);
            this.MovieComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.MovieComboBox.Name = "MovieComboBox";
            this.MovieComboBox.Size = new System.Drawing.Size(265, 28);
            this.MovieComboBox.Sorted = true;
            this.MovieComboBox.TabIndex = 2;
            this.MovieComboBox.SelectedIndexChanged += new System.EventHandler(this.MovieComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Select a Movie";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            this.MovieTitleTextBox.Enabled = false;
            this.MovieTitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.MovieTitleTextBox.Location = new System.Drawing.Point(15, 217);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(265, 29);
            this.MovieTitleTextBox.TabIndex = 4;
            this.MovieTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.BackColor = System.Drawing.Color.White;
            this.MovieGenreTextBox.Enabled = false;
            this.MovieGenreTextBox.ForeColor = System.Drawing.Color.Black;
            this.MovieGenreTextBox.Location = new System.Drawing.Point(15, 252);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.ReadOnly = true;
            this.MovieGenreTextBox.Size = new System.Drawing.Size(130, 29);
            this.MovieGenreTextBox.TabIndex = 5;
            this.MovieGenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MoviePriceTextBox
            // 
            this.MoviePriceTextBox.BackColor = System.Drawing.Color.White;
            this.MoviePriceTextBox.Enabled = false;
            this.MoviePriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.MoviePriceTextBox.Location = new System.Drawing.Point(150, 252);
            this.MoviePriceTextBox.Name = "MoviePriceTextBox";
            this.MoviePriceTextBox.ReadOnly = true;
            this.MoviePriceTextBox.Size = new System.Drawing.Size(130, 29);
            this.MoviePriceTextBox.TabIndex = 6;
            this.MoviePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(15, 435);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 35);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(170, 435);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 35);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(299, 15);
            this.MoviePosterPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(355, 455);
            this.MoviePosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePosterPictureBox.TabIndex = 1;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 485);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MoviePriceTextBox);
            this.Controls.Add(this.MovieGenreTextBox);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieComboBox);
            this.Controls.Add(this.MoviePosterPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.ComboBox MovieComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MoviePriceTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}

