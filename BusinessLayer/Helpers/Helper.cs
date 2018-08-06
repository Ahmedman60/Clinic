using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;
namespace BusinessLayer
{
   public static class Helper
    {
        public static  bool isActive = false;
        public static void ClearAllTextBox(Control Form)
        {

       
            //form is collection of contols
            foreach (Control item in Form.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is GroupBox)
                {
                    ClearAllTextBox(item);
                }
            }
        }

        public static void fillComboandGradViews(Control Control, DataTable DataSource, string Display = null,string Value=null)
        {
            if(Control is ComboBox)
            {
                ((ComboBox)Control).DataSource = DataSource;
                ((ComboBox)Control).DisplayMember = DataSource.Columns["RoleName"].ToString();
                ((ComboBox)Control).ValueMember = DataSource.Columns["RoleID"].ToString();

            }
            else
            {
                ((DataGridView)Control).DataSource = DataSource;
            }

        }
    }
}
