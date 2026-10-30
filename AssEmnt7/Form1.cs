using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssEmnt7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bwriteline_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText("this file.doc");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya");
            lines.WriteLine("class ca244");
            lines.WriteLine("fardowsa mohamed Noor");
            MessageBox.Show("File successfully created and written!");
            //closing the lines
            lines.Close();
        }
        

        private void bDeletfile_Click(object sender, EventArgs e)
        { //  Delete file button delete files
            if (File.Exists("this file.doc"))
            {
                File.Delete("this file.doc");
              lResult.Items.Clear();
                MessageBox.Show("clear file.");
            }
            else
            {
                MessageBox.Show("file lama helin.");
            }

        }

        private void bReadALLline_Click(object sender, EventArgs e)
        {
            lResult.Items.Clear();
            if (File.Exists("this file.doc"))
            {
                string[] lines = File.ReadAllLines("this file.doc");

                foreach (string line in lines)
                {
               lResult.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void bReadline_Click(object sender, EventArgs e)
        {
           lResult.Items.Clear();
            if (File.Exists("this file.doc"))
            {
                foreach (string line in File.ReadLines("this file.doc"))
                {
                    lResult.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }
    

        private void bDeletitem_Click(object sender, EventArgs e)
        {
           lResult.Items.Clear();
        }
    }
}
