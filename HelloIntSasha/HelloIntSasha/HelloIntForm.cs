using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntSasha
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour, le monde!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Spanish
            this.lblGreeting.Text = "Hola, Mundo!";
        }

        private void RadItalian_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Italian
            this.lblGreeting.Text = "Ciao, Mondo!";
        }
    }
}
