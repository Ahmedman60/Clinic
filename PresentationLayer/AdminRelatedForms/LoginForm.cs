using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using BusinessLayer;
using System.IO;
namespace PresentationLayer
{
    
    public partial class LoginForm : Form
    {
        AdminBL Employee = new AdminBL(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public LoginForm()
        {
            InitializeComponent();
        }

     

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((int)Employee.AdminLogin(txtID.Text, txtPass.Text) > 0)
            {
                DialogResult s = MessageBox.Show("Welcome Admin");
                Helper.isActive = true;

                if (s == DialogResult.OK)
                {
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
        }
    }
}
