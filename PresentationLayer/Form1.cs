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
    public partial class AdmForm : Form
    {
        //Design

        bool hide;
        //Desing
        string Conn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        AdminBL Employee = new AdminBL(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        string _FileName;
        byte[] MyImage;
        byte[] ReadyImage;
       public AdmForm()
        {
            InitializeComponent();
        }

        private void AdmForm_Load(object sender, EventArgs e)
        {
            Helper.fillComboandGradViews(cmbRole, new AdminBLRole(Conn).SelectRoles(), "RoleName", "RoleID");
            hide = true;
            btnHide.Enabled = false;
            panel1.Width = 740;

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Helper.fillComboandGradViews(dataGridView1, Employee.ReadAll());
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddRoleForm().ShowDialog();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (GetEmployeeData()==null)
            {
                MessageBox.Show("Are You Sure You Insert Name ! or Any Data \n AI SPEAKING  smart app ha :D");
            }
            else {

                if (Employee.EmployeeInsert(GetEmployeeData()) > 0)
                {
                    MessageBox.Show("Saved Done");
                    Helper.ClearAllTextBox(this);
                }
            }


        }


        public AdminBL GetEmployeeData()
        {
            //Reading The Image
            if (_FileName != null)
            {
                //FileStream fs = new FileStream(_FileName, FileMode.Open, FileAccess.Read);
                //fs.Seek(0, SeekOrigin.Begin);
                //fs.Read(MyImage, 0, (int)new FileInfo(_FileName).Length);
                ReadingImageFromFile();
            }
            else
            {
                MessageBox.Show("Insert Image");
                return null;
            }

            //Read Normal Data
            AdminBL EmployeeData = new AdminBL()
            {

                Name = txtname.Text ,
                Salary = nupdSalary.Value,
                About = richTextBox1.Text,
                Age = Convert.ToInt16(txtage.Text),
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                RoleID = Convert.ToInt32(cmbRole.SelectedValue),
                Image = MyImage
            };

            if (Name == "" )
            {
                return null;
            }

            return EmployeeData;

        }

        private void ReadingImageFromFile()
        {
            FileStream fs = new FileStream(_FileName, FileMode.Open, FileAccess.Read);
            BinaryReader Br = new BinaryReader(fs);
            FileInfo Fi = new FileInfo(_FileName);
            MyImage = Br.ReadBytes((int)Fi.Length);
        }

        private void invokeimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "|*.jpg;*.BMP;*.Png";
            Open.Title = "GetImage";
            Open.CheckPathExists = true;
            if (Open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Open.FileName;
                _FileName = Open.FileName;
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (hide == false)
            {

                btnHide.Text = "Hide";
            }
            else
            {
                btnHide.Text = "Show";

            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide == true)
            {
                panel1.Width = panel1.Width + 20;
                if (panel1.Width >= 755)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 20;
                if (panel1.Width <= 42)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }
       bool firsttime = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
            new LoginForm().ShowDialog();
                firsttime = false;
            }
           
            if (Helper.isActive == true)
            {
                btnHide.Enabled = true;
            }
            else if(Helper.isActive==false)
            {
                btnHide.Enabled = false;
                new LoginForm().ShowDialog();
            }
            else if(btnHide.Enabled == true)
            {
                button1.Enabled = false;
            }
            
           // MessageBox.Show("I Told You This is a Shit Application ^^", "Wrong Button :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public AdminBL FillEmployee()
        {
            AdminBL OldEmployee = new AdminBL()
            {
                ID = int.Parse(txtID.Text),
                Name = txtname.Text,
                Salary = nupdSalary.Value,
                About = richTextBox1.Text,
                Age = Convert.ToInt16(txtage.Text),
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                RoleID = Convert.ToInt32(cmbRole.SelectedValue)
            };
            //this when update image remove error

            //cuz it doesn't insert image
            if (_FileName != null)
            {
                ReadingImageFromFile();
                OldEmployee.Image = MyImage;
            }
            else if (MyImage == null )
            {
                OldEmployee.Image = ReadyImage;
            }
           
            return OldEmployee;
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Employee.EmployeeUpdate(FillEmployee());
                btnshow.PerformClick();
            }
            else
            {
                MessageBox.Show("Select Employee to Edit it");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value ;
            AdminBL Data = Employee.SelectEmployeeByID(id);

            ReadyImage = Data.Image;
            try
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(Data.Image));
            }
            catch (ArgumentNullException)
            {
                pictureBox1.Image= Image.FromFile(@"C:\Users\Mo-Feto\Desktop\Person Female_96px.png");
            }
            txtname.Text = Data.Name;
            txtID.Text = Data.ID.ToString();
            txtage.Text = Data.Age.ToString();
            nupdSalary.Value = Data.Salary;
            cmbRole.SelectedValue = Data.RoleID.ToString();
            txtusername.Text = Data.UserName;
            txtpassword.Text = Data.Password;




        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text !="")
            {
                DialogResult d = MessageBox.Show("Are You Sure ", "Worng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    Employee.DeleteEmployee(int.Parse(txtID.Text));
                        }
                else
                {
                    return;
                }



            }
            else
            {
                MessageBox.Show("Please Select Employee to Be Deleted");
            }
        }
    }
}
