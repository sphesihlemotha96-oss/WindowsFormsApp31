using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee obj =new employee();
            obj.hoursWorked=Convert.ToInt32(txtHoursWorked.Text);
            obj.hourlyRate = Convert.ToInt32(txtHourlyRate.Text);

 
            obj.calcSalary();
            obj.calcDeductuctions();

            lblSalary.Text = "Salary:" + obj.salary.ToString("0.00");
            lblDeductions.Text = "Deductions:" + obj.deductions.ToString("0.00");

        }
    }
}
