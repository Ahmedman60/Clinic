using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace BusinessLayer.Reciption
{
    class Patient:DAL
    {
        public Patient()
        {

        }
        public Patient(string Connection) : base(Connection)
        {

        }

        //Filed of Patient
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime EnterDate { get; set; }
        public int ReciptionID { get; set; } //the one how enter 
        public int DoctorID { get; set; } //come from select all doctos in combox 
        public DateTime AppointmentDate { get; set; }

        public DataTable GetReciption(string username, string password)
        {
            SqlParameter[] s = new SqlParameter[2];
            s[0] = new SqlParameter("@UserName", username);
            s[1] = new SqlParameter("@Passoword", password);
            return ExecReader("GetCurrentReciption", CommandType.StoredProcedure, para:s);
        }


       

    }
}
