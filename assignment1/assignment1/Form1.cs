using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            String studentname,  department ;
            int studentid,semester;
            
            studentname = txtstudentname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);
            //display all
            lbloutput.Text = studentname + " " + studentid + " " + department + " " + semester;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }
    }
}
