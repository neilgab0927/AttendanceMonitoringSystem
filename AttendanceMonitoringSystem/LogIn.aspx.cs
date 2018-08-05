using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AttendanceMonitoringSystem.Models;


namespace AttendanceMonitoringSystem
{
    public partial class LogIn : System.Web.UI.Page
    {
        //GENERATE DB CODES
        private AMSDBEntities1 db = new AMSDBEntities1();

        //COPY PASTE EVERY CODEBEHIND
       // private string strConnString { get { return ConfigurationManager.ConnectionStrings["AMSconnect"].ConnectionString; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            /// LblUser.Text = Session[""].ToString();
            ///LblPass.Text = Session["P@ssword"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Tbl_LogIn.ToList().Any(z => z.Username == TxtUser.Text && z.Password == TxtPass.Text);

                if(result)
                {
                    Cache["user"] = TxtUser.Text;
                    Response.Redirect("Registration.aspx");
                   
                }
                else
                { LblComment.Text = "Invalid login!"; }
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
                Session.RemoveAll();
                
            }
        }

    }
}
