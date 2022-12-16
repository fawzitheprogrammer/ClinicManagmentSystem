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
        public static int DataInsertUpdateDelete(string proc,Hashtable ht)
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
            }
            catch(Exception ex)
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
            } catch(Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
        }

        public static void searchData(string proc, DataGridView dg, ListBox listBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", listBox.Items[0]);
                cmd.Parameters.AddWithValue("@id", listBox.Items[0]);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
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
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
        }

    }
}
