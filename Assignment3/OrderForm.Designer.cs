namespace Assignment3
{
    partial class OrderForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.StreamButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.DVDPriceLabel = new System.Windows.Forms.Label();
            this.DVDPriceTextBox = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.YourOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuOption,
            this.HelpMenuOption});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(20, 7, 0, 7);
            this.Menu.Size = new System.Drawing.Size(669, 33);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenuOption
            // 
            this.FileMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintMenuSelection,
            this.StreamMenuSelection,
            this.ExitMenuSelection});
            this.FileMenuOption.Name = "FileMenuOption";
            this.FileMenuOption.Size = new System.Drawing.Size(37, 19);
            this.FileMenuOption.Text = "File";
            // 
            // PrintMenuSelection
            // 
            this.PrintMenuSelection.Name = "PrintMenuSelection";
            this.PrintMenuSelection.Size = new System.Drawing.Size(152, 22);
            this.PrintMenuSelection.Text = "Print";
            // 
            // StreamMenuSelection
            // 
            this.StreamMenuSelection.Name = "StreamMenuSelection";
            this.StreamMenuSelection.Size = new System.Drawing.Size(152, 22);
            this.StreamMenuSelection.Text = "Stream";
            // 
            // ExitMenuSelection
            // 
            this.ExitMenuSelection.Name = "ExitMenuSelection";
            this.ExitMenuSelection.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuSelection.Text = "Exit";
            this.ExitMenuSelection.Click += new System.EventHandler(this.ExitMenuSelection_Click);
            // 
            // HelpMenuOption
            // 
            this.HelpMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuSelection});
            this.HelpMenuOption.Name = "HelpMenuOption";
            this.HelpMenuOption.Size = new System.Drawing.Size(44, 19);
            this.HelpMenuOption.Text = "Help";
            // 
            // AboutMenuSelection
            // 
            this.AboutMenuSelection.Name = "AboutMenuSelection";
            this.AboutMenuSelection.Size = new System.Drawing.Size(152, 22);
            this.AboutMenuSelection.Text = "About";
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.MoviePosterPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(12, 36);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(296, 437);
            this.MovieSelectedGroupBox.TabIndex = 2;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.DVDPriceTextBox);
            this.YourOrderGroupBox.Controls.Add(this.DVDPriceLabel);
            this.YourOrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubtotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubtotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(315, 36);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(342, 396);
            this.YourOrderGroupBox.TabIndex = 3;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(547, 438);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(110, 35);
            this.StreamButton.TabIndex = 9;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(431, 438);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 35);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(315, 438);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 35);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(7, 46);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(52, 23);
            this.MovieTitleLabel.TabIndex = 0;
            this.MovieTitleLabel.Text = "Title";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            this.MovieTitleTextBox.Enabled = false;
            this.MovieTitleTextBox.Location = new System.Drawing.Point(6, 72);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(284, 37);
            this.MovieTitleTextBox.TabIndex = 1;
            this.MovieTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.BackColor = System.Drawing.Color.White;
            this.MovieGenreTextBox.Enabled = false;
            this.MovieGenreTextBox.Location = new System.Drawing.Point(6, 142);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.ReadOnly = true;
            this.MovieGenreTextBox.Size = new System.Drawing.Size(284, 37);
            this.MovieGenreTextBox.TabIndex = 2;
            this.MovieGenreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(11, 116);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(66, 23);
            this.MovieGenreLabel.TabIndex = 3;
            this.MovieGenreLabel.Text = "Genre";
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(7, 186);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(283, 245);
            this.MoviePosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePosterPictureBox.TabIndex = 4;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Location = new System.Drawing.Point(215, 43);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 37);
            this.CostTextBox.TabIndex = 0;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.BackColor = System.Drawing.Color.White;
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Location = new System.Drawing.Point(215, 129);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(100, 37);
            this.SubtotalTextBox.TabIndex = 1;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.BackColor = System.Drawing.Color.White;
            this.SalesTaxTextBox.Enabled = false;
            this.SalesTaxTextBox.Location = new System.Drawing.Point(215, 173);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 37);
            this.SalesTaxTextBox.TabIndex = 2;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.BackColor = System.Drawing.Color.White;
            this.GrandTotalTextBox.Enabled = false;
            this.GrandTotalTextBox.Location = new System.Drawing.Point(215, 217);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 37);
            this.GrandTotalTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(134, 46);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(52, 23);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(99, 132);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(87, 23);
            this.SubtotalLabel.TabIndex = 5;
            this.SubtotalLabel.Text = "Subtotal";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(32, 176);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(154, 23);
            this.SalesTaxLabel.TabIndex = 6;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(65, 220);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(121, 23);
            this.GrandTotalLabel.TabIndex = 7;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Location = new System.Drawing.Point(39, 363);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(263, 27);
            this.DVDCheckBox.TabIndex = 8;
            this.DVDCheckBox.Text = "Order DVD copy ($10.00)";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // DVDPriceLabel
            // 
            this.DVDPriceLabel.AutoSize = true;
            this.DVDPriceLabel.Location = new System.Drawing.Point(84, 89);
            this.DVDPriceLabel.Name = "DVDPriceLabel";
            this.DVDPriceLabel.Size = new System.Drawing.Size(102, 23);
            this.DVDPriceLabel.TabIndex = 9;
            this.DVDPriceLabel.Text = "DVD Price";
            this.DVDPriceLabel.Visible = false;
            // 
            // DVDPriceTextBox
            // 
            this.DVDPriceTextBox.BackColor = System.Drawing.Color.White;
            this.DVDPriceTextBox.Enabled = false;
            this.DVDPriceTextBox.Location = new System.Drawing.Point(215, 86);
            this.DVDPriceTextBox.Name = "DVDPriceTextBox";
            this.DVDPriceTextBox.ReadOnly = true;
            this.DVDPriceTextBox.Size = new System.Drawing.Size(100, 37);
            this.DVDPriceTextBox.TabIndex = 10;
            this.DVDPriceTextBox.Visible = false;
            // 
            // OrderForm
            // 
            this.AcceptButton = this.StreamButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 485);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuOption;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuSelection;
        private System.Windows.Forms.ToolStripMenuItem StreamMenuSelection;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuSelection;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuOption;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuSelection;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox DVDPriceTextBox;
        private System.Windows.Forms.Label DVDPriceLabel;
    }
}