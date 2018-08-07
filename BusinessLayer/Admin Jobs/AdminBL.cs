using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace BusinessLayer
{
   public class AdminBL : DAL
    {
        //Constractor
        public AdminBL()
        {

        }
        public AdminBL(string Connection) : base(Connection)
        {

        }
        //Filed of ADMIN PAGE
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int RoleID { get; set; } 
        public string About { get; set; }
        public byte[] Image { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //Method Wich is a stored procdure in the sql server

        public int EmployeeInsert(AdminBL NewEmployee)
        {
            SqlParameter[] parm = new SqlParameter[8];
            parm[0] = new SqlParameter("@Name", NewEmployee.Name);
            parm[1] = new SqlParameter("@Age", NewEmployee.Age);
            parm[2] = new SqlParameter("@Salary", NewEmployee.Salary);
            parm[3] = new SqlParameter("@RoleID", NewEmployee.RoleID);
            parm[4] = new SqlParameter("@About", NewEmployee.About);
            parm[5] = new SqlParameter("@image", NewEmployee.Image);
            parm[6] = new SqlParameter("@UserName", NewEmployee.UserName);
            parm[7] = new SqlParameter("@Password", NewEmployee.Password);
            return ExecNonQuery("Sp_InsertEmployee", CommandType.StoredProcedure, parm);
        }

        public int EmployeeUpdate(AdminBL OldEmployee)
        {
            SqlParameter[] parm = new SqlParameter[9];
            parm[8] = new SqlParameter("@ID", OldEmployee.ID);
            parm[0] = new SqlParameter("@Name", OldEmployee.Name);
            parm[1] = new SqlParameter("@Age", OldEmployee.Age);
            parm[2] = new SqlParameter("@Salary", OldEmployee.Salary);
            parm[3] = new SqlParameter("@RoleID", OldEmployee.RoleID);
            parm[4] = new SqlParameter("@About", OldEmployee.About);
            parm[5] = new SqlParameter("@image", OldEmployee.Image);
            parm[6] = new SqlParameter("@UserName", OldEmployee.UserName);
            parm[7] = new SqlParameter("@Password", OldEmployee.Password);
            return ExecNonQuery("Sp_UpdateEmployee", CommandType.StoredProcedure, parm);
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_SelectAllEmployee");

        }

        public AdminBL SelectEmployeeByID(int ID)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);

           DataTable tb= ExecReader("sp_SelectEmployeeByID", CommandType.StoredProcedure, parm);
            AdminBL Employee = new AdminBL();
            Employee.ID = (int)tb.Rows[0][0];
            Employee.Name = tb.Rows[0][1].ToString();
            Employee.Age = Convert.ToInt32(tb.Rows[0]["Age"].ToString());
            Employee.Salary = (decimal)tb.Rows[0][3];
            Employee.RoleID = (int)tb.Rows[0][4];
            Employee.About = tb.Rows[0][5].ToString();
            //put it in stream to use it
            Employee.Image = tb.Rows[0][6] as byte[];

            Employee.UserName = tb.Rows[0]["UserName"].ToString();
            Employee.Password = tb.Rows[0]["Password"].ToString();
            return Employee;
        }


        public void DeleteEmployee(int id)
        {
            SqlParameter[] s = new SqlParameter[1];
            s[0] = new SqlParameter("@ID", id);
            ExecNonQuery("Sp_DeleteEmployee",para:s);
        }
        public object AdminLogin(string username,string password)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@UserName",username);
            s[1] = new SqlParameter("@Passoword",password);
          return  ExecScalar("SP_CheckAdmin", para: s);
        }
    }
}
