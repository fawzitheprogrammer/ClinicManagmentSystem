using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Authentication
{
    public class login
    {

        // Two  private variable to take userID & roleID value later on this code
        private static int userID, roleID;

        // Two  private variable to take name & role value later on this code
        private static string name, role;


        // a static class to get ser ID
        public static int UserID
        {

            get { return userID; }
            set { userID = value; }
        }


        // a static class to get roleID
        public static int RoleID
        {

            get { return roleID; }
            set { roleID = value; }
        }



        // a static class to get and set name for username 
        public static string Name
        {

            get { return name; }
            set { name = value; }
        }


        // a static class to get and set role for user
        public static string Role
        {

            get { return role; }
            set { role = value; }
        }


        // Implementaion of getting user from the database reading and then getting the value
        public static bool getLoginDetails(string proc,Hashtable ht)
        {

            bool isChecked = false;

            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // looping through hash table to get the data input from the user
                foreach(DictionaryEntry item in ht)
                {
                    // sending the data to the stored procedure that we have created
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                mainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isChecked = true;
                    while (dr.Read())
                    {
                        UserID = Convert.ToInt32(dr[0].ToString());
                        Name = dr[1].ToString();

                        RoleID = Convert.ToInt32(dr[2].ToString());
                        Role = dr[3].ToString();
                    }
                }
                else
                {
                    isChecked = false;
                    mainClass.showMessage("Invalid username or password", false);
                }
                mainClass.con.Close();
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMessage(ex.ToString(), false);
            }

            return isChecked;

        }
    }
}
