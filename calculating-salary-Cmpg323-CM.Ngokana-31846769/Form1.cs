using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculating_salary_Cmpg323_CM.Ngokana_31846769
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            int Hworked = Convert.ToInt32(txtHW.Text);
            int Hrate = Convert.ToInt32(txtHRate.Text);

            int salary = Hworked * Hrate * 30;

            MessageBox.Show("Your monthly salary is R" + salary);
        }

        private void txtHW_TextChanged(object sender, EventArgs e)
        {
            //int Hworked = Convert.ToInt32(txtHW);
        }

        private void txtHRate_TextChanged(object sender, EventArgs e)
        {
            //int Hrate = Convert.ToInt32(txtHRate);
        }
    }
}
