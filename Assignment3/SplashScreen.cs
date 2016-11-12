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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            WaitTimer.Dispose(); // get rid of the timer so it doesnt keep opening the generate name form.
            this.Hide();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
        }
    }
}
