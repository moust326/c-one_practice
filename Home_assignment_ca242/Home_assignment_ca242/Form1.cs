using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_assignment_ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //stage1 of input
            //creating variables
            String day_of_the_week, name_of_the_month,  full_date;
            int numeric_day, year;
            //initial values
            day_of_the_week = txtdayoftheweek.Text;
            name_of_the_month = txtnameofthemonth.Text;
            //type casting using parse
            numeric_day = int.Parse(txtnumberofmonth.Text);
            year =int.Parse( txtyear.Text);
            //stage2 process concatination of full date
            full_date = day_of_the_week + "," + name_of_the_month + "," + numeric_day + "," + year;
            //stage3 the output using label
            lbloutput.Text = full_date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear textbox and label
            txtdayoftheweek.Clear();
            txtnumberofmonth.Text = "";
            txtnameofthemonth.Text = string.Empty;
            txtyear.Clear();
            //clearing the output
            lbloutput.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form close using this keyword and close functinon
            this.Close();
        }
    }
}
