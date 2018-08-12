using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.Sql;

using System.Configuration;
namespace PresentationLayer
{
    public partial class AddRoleForm : Form
    {
        string Conn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        AdminBL ConnectedAdmin = new AdminBL(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public AddRoleForm()
        {
            InitializeComponent();

            Helper.fillComboandGradViews(comboBox1, new AdminBLRole(Conn).SelectRoles(), "RoleName", "RoleID");
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            AdminBLRole s = new AdminBLRole();
            s.Name = textBox1.Text;
            new AdminBLRole(Conn).insertRole(s);
            this.Close();
        }
    }
}
