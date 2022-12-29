using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MainClass;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace CRUD
{
    public class crud
    {
        public static int DataInsertUpdateDelete(string proc,Hashtable ht,string isDoneMessage)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc,mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(System.Collections.DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
               /* for(int i= 0; i < listBoxOne.Items.Count; i++)
                {
                    cmd.Parameters.AddWithValue(listBoxOne.Items[i].ToString(),listBoxTwo.Items[0]);
                }*/
                mainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.showMessage(isDoneMessage, true);
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMessage(ex.Message, false);
            }

            return res;
        }

        public static void loadData(string proc,DataGridView dg,ListBox listBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc,mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i = 0; i < listBox.Items.Count; i++)
                {
                    string colNameOne = ((DataGridViewColumn)listBox.Items[i]).Name;
                    dg.Columns[colNameOne].DataPropertyName = dt.Columns[i].ToString();
                }
                dg.DataSource = dt;
                int count = 0;

                foreach(DataGridViewRow row in dg.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            } catch(Exception)
            {
               // mainClass.showMessage(ex.ToString(), false);
            }
        }


        public static void loadRole(string proc,ComboBox cb,string valueMember,string displayMember)
        {


            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.SelectedIndex = -1;
 
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }


        }

        public static void searchData(string proc, DataGridView dg,ListBox listBox, string text)
        {



            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@theText", text);



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        string colNameOne = ((DataGridViewColumn)listBox.Items[i]).Name;
                        dg.Columns[colNameOne].DataPropertyName = dt.Columns[i].ToString();
                    }


                    dg.DataSource = dt;

                    int count = 0;

                    foreach (DataGridViewRow row in dg.Rows)
                    {
                        count++;
                        row.Cells[0].Value = count;
                    }
                }
                else
                {
                    mainClass.showMessage("There is no record matching", false);
                }
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }





            /*try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@theText", text);

                mainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                var dataTable = dg.DataSource as DataTable;








         //       int i = 0;

                if (dr.HasRows)
                {
                    dataTable.Rows.Clear();


                    while (dr.Read())
                    {

                        Object newObj = new Object[7];

                        foreach(Object o in dr)
                        {
                           
                        }
                        
                    }

                    
                }
                else
                {
                    mainClass.showMessage("There is no record matching", false);
                }
                dr.Close();
                mainClass.con.Close();
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMessage(ex.ToString(), false);
            }*/
        }

    }
}
