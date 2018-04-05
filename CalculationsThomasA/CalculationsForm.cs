/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Calculations
 * This program calculates and displays the answer to the numbers in the label
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

namespace CalculationsThomasA
{
    public partial class frmCalculations : Form
    {
        public frmCalculations()
        {
            InitializeComponent();
        }

        // Calculate and display question 1
        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(5 + Math.Pow(2, 3));
        }

        // Calculate and display question 2
        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(4 / 2 + 5);
        }

        // Calculate and display question 3
        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(3 + 4 * 2);
        }

        // Calculate and display question 4
        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            lblAnswer4.Text = Convert.ToString(7 - 3 + 2);
        }
    }
}
