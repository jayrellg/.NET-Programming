using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW__08_Advanced_Windows_Forms.Views
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            rtbAboutText.Text = Properties.Resources.About;

        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the About dialog

        }
    }
}
