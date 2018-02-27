using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibertyWealth.DataAccessLayer.DAO;
using Dapper;
namespace LibertyWealth.DataAccessLayer
{
   public class DataAccess
    {
      SqlConnection con = new SqlConnection("Data Source=DELL-PC;Initial Catalog=lw4uDB;Integrated Security=True");
       
        public bool AddUser(tblUser user)
        {
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@FirstName", user.FirstName);
                para.Add("@Surname", user.Surname);
                para.Add("@CellphoneNumber", user.CellphoneNumber);
                para.Add("@UserRoleId", user.UserRoleId);
                para.Add("@DateCreated", user.DateCreated);
                para.Add("@Email", user.Email);
                para.Add("@EmailConfirmed", user.EmailConfirmed);
                para.Add("@TwoFactorCount", user.TwoFactorCount);
                para.Add("@LockedOut", user.LockedOut);
                para.Add("@Password", user.Password);
                con.Execute("UserAddorEdit", para, commandType: CommandType.StoredProcedure);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteUser(int userid)
        {
            DynamicParameters para = new DynamicParameters();
            para.Add("@UserId", userid);
            con.Execute("DeleteUser", para, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateUser(tblUser user)
        {
            try
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@FirstName", user.FirstName);
                para.Add("@Surname", user.Surname);
                para.Add("@CellphoneNumber", user.CellphoneNumber);
                para.Add("@UserRoleId", user.UserRoleId);
                para.Add("@DateCreated", user.DateCreated);
                para.Add("@Email", user.Email);
                para.Add("@EmailConfirmed", user.EmailConfirmed);
                para.Add("@TwoFactorCount", user.TwoFactorCount);
                para.Add("@LockedOut", user.LockedOut);
                para.Add("@Password", user.Password);
                con.Execute("UpdateUser", para, commandType: CommandType.StoredProcedure);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<tblUser> GetAllUser()
        {
            IList<tblUser> customerList = con.Query<tblUser>("GetAllUsers", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }


    }



}

