/*
 * Created by: Sasha Malko
 * Created on: 10-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
 * This program displays the greeting in different languages depending on which radio button is clicked. 
*/
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
