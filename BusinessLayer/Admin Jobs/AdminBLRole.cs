using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace BusinessLayer
{
   public  class AdminBLRole:DAL
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  AdminBLRole()
        {

        }
        public AdminBLRole(string Connection) : base(Connection)
        {

        }
      
        public int insertRole(AdminBLRole newRole)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@Name", newRole.Name);
           return ExecNonQuery("Sp_InsertIntoRoles", CommandType.StoredProcedure, parm);
        }

        public DataTable SelectRoles()
        {
             return ExecReader("Sp_SelectAllRoles", para: null);
        }
    }
}
