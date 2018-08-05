using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class Registration : System.Web.UI.Page
    {
        //COPY PASTE EVERY CODEBEHIND
        /// private string strConnString { get { return ConfigurationManager.ConnectionStrings["AMSconnect"].ConnectionString; } }
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AMSconnect"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Position();
           
        }

        public void Load_Position()//Display the data of Dropdownlist for Position.
        {

            string strConnString = null;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertPosition";
                    cmd.Connection = con;
                    con.Open();
                    ddlPosition.DataSource = cmd.ExecuteReader();
                    ddlPosition.DataTextField = "Position";
                    ddlPosition.DataValueField = "ID";
                    ddlPosition.DataBind();
                    ddlPosition.Items.Insert(0, new ListItem("-Select Position-", "0"));
                    con.Close();
                  
                }
            }
        }

  

        private void Display_RegsForm() //display data in calssrecord gridview.
        {
            string strConnString = null;
            using (SqlConnection conn = new SqlConnection(strConnString))
            {

                using (SqlCommand comm = new SqlCommand("InsertRegsForm", conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@ID", TxtStudentNo.Text.ToString());
                    gvClassRecord.EmptyDataText = "No Records Found";
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        sda.SelectCommand = comm;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            gvClassRecord.DataSource = dt;
                            gvClassRecord.DataBind();
                        }
                    }
                }

            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            string strConnString = null;
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand("InsertRegsForm", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Name", TxtName.Text.ToString());
            cmd.Parameters.AddWithValue("@Program", TxtProgram.Text.ToString());
            cmd.Parameters.AddWithValue("@ID", TxtStudentNo.Text.ToString());
            cmd.Parameters.AddWithValue("@Year", TxtYear.Text.ToString());
            cmd.Parameters.AddWithValue("@Position", ddlPosition.SelectedItem.Value.ToString());

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}