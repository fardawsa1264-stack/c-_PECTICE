using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void claer_Click(object sender, EventArgs e)
        {
            dyofwktxtbx.Clear();
            dyofmnthtxtbx.Clear();
            yeartxtbx.Clear();
            mnthtextbx.Clear();
            lbldataouput.Text= string.Empty;
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            string dayweek, month, year, daymonth ,fulldata;
            dayweek = dyofwktxtbx.Text;
            month = mnthtextbx.Text;
            year = yeartxtbx.Text;
           daymonth = dyofmnthtxtbx.Text;
           fulldata=dayweek+";"+month+";"+year+";"+daymonth+";";
            lbldataouput.Text = fulldata;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
