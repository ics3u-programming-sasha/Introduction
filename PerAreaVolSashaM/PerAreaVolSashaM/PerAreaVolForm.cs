/*
 * Created by: Sasha Malko
 * Created on: 10-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter, Area & Volume
 * This program calculates the perimeter of a rectangle, the area of a circle, and the volume of a sphere. 
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

namespace PerAreaVolSashaM
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            //calculate the perimeter of the rectangle
            this. lblAPerimeter.Text = Convert.ToString(5 + 5 + 8 + 8) + " cm";

        }

        private void BtnQArea_Click(object sender, EventArgs e)
        {
            //calculate the area of the circle
            this. lblAArea.Text = Convert.ToString(Math.Pow(7,2) * Math.PI) + " cm²";
        }

        private void BtnQVolume_Click_1(object sender, EventArgs e)
        {
            //calculate the volume of the sphere
            this. lblAVolume.Text = Convert.ToString((double)4 / (double)3 * Math.PI * Math.Pow(4,3)) + " cm³ ";
        }

    }
}