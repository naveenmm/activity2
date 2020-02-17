using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;

namespace activity2
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

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            String uname = name.Text;
            String mail = email.Text;
            String fname = filename.Text;
            string path = @"C:\Users\admin.INL083\source\repos\activity1\activity1\" + fname;
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("Existing File deleted");
            }
            using (FileStream fs = File.Create(fname))
            {
            }
            details emp = new details();
            if (!this.email.Text.Contains('@') || !this.email.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email");
            }
            else
            {
                emp.name = uname;
                emp.email = mail;

                string JSONresult = JsonConvert.SerializeObject(emp);

                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
                label4.Text = (JSONresult.ToString());
            }
        }
    }
}
