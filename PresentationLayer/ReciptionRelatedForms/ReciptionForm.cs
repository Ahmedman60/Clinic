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
namespace PresentationLayer.ReciptionRelatedForms
{
    public partial class ReciptionForm : Form
    {

        string Connection = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        BusinessLayer.Reciption.Patient _ConnPatient = new BusinessLayer.Reciption.Patient(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public ReciptionForm()
        {
            InitializeComponent();
        }
        int? EmployeeID=null;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            DataTable dt = _ConnPatient.GetReciption(textBox1.Text, textBox2.Text);
           
            if (dt.Rows.Count>0)
            {
                lblID.Text = dt.Rows[0][0].ToString();
                EmployeeID = int.Parse(dt.Rows[0][0].ToString());
                lblName.Text = dt.Rows[0][1].ToString();
              
                try
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(dt.Rows[0][2] as byte[]));
                }
                catch (ArgumentNullException)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Mo-Feto\Desktop\Person Female_96px.png");
                   
                   
                }
            }else
            {
                MessageBox.Show("Error");
            }
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void ReciptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
            // TODO: This line of code loads data into the 'clinicDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.clinicDataSet.Patient);
          
        }

        private void patientBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            reciptionIDTextBox.Text = lblID.Text;
        }

       
    }
}
