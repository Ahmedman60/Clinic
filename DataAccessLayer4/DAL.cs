using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public abstract class DAL
    {
        private readonly string _StrCon;
        public DAL()
        {

        }
        public DAL(string con)
        {
            _StrCon = con;
        }
        public string StrCon
        {
            get
            {
                return _StrCon;
            }
        }
        /// <summary>
        /// this method used for insert,update delete 
        /// </summary>
        /// <param name="cmdtext">CommandText,Or Stored Procedure Name</param>
        /// <param name="cmdtype">CommandType</param>
        /// <param name="para">Array SqlParameter</param>
        /// <returns>Number Of Effected Rows</returns>
        //CUD
        protected int ExecNonQuery(string cmdtext, CommandType cmdtype = CommandType.StoredProcedure, SqlParameter[] para = null)
        {
            using (SqlConnection con = new SqlConnection(_StrCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = cmdtype;
                if (para != null)
                {
                    for (int i = 0; i < para.Length; i++)
                    {
                        cmd.Parameters.Add(para[i]); //you send full parameter whit it's value to here ^^
                    }
                }
                return cmd.ExecuteNonQuery();
            }
        }
        //Read
        //it return sqldatareader but i want a datatable to make it a datasource for something

        protected DataTable ExecReader(string cmdtext, CommandType cmdtype = CommandType.StoredProcedure, SqlParameter[] para = null)
        {
            using (SqlConnection con = new SqlConnection(_StrCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = cmdtype;
                if (para != null)
                {
                    for (int i = 0; i < para.Length; i++)
                    {
                        cmd.Parameters.Add(para[i]);
                    }
                }
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }
        //Scalar
        protected object ExecScalar(string cmdtext, CommandType cmdtype = CommandType.StoredProcedure, SqlParameter[] para = null)
        {
            using (SqlConnection con = new SqlConnection(_StrCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = cmdtype;
                if (para != null)
                {
                    for (int i = 0; i < para.Length; i++)
                    {
                        cmd.Parameters.Add(para[i]);
                    }
                }
                return cmd.ExecuteScalar();
            }
        }
    }
}
