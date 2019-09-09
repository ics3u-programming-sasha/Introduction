/*
 * Created by: Sasha Malko
 * Created on: Sept. 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Program with Menu
 * This program displays my favourite soccer team with player and has an exit menu
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

namespace ProgramMenuSasha
{
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void LblTeam_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // this will close the program
            this.Close();
        }
    }
}
