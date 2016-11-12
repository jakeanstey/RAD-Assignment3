using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class StreamForm : Form
    {
        private String title;
        private double total;

        public StreamForm(String title, double total)
        {
            InitializeComponent();
            this.Text = title;
            this.title = title;
            this.total = total;

            Initialize();
        }

        /// <summary>
        /// start up code.
        /// </summary>
        private void Initialize()
        {
            CCAuthLabel.Text = "Your credit card has been charged $" + total.ToString("0.##");
            MovieStreamNotificationLabel.Text = title + " will begin streaming now.";
        }

        /// <summary>
        /// Beam me up, Scotty!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkayButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
