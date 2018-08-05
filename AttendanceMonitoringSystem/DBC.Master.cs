using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class DBC : System.Web.UI.MasterPage
    {
        //COPY PASTE EVERY CODEBEHIND
        private string strConnString { get { return ConfigurationManager.ConnectionStrings["AMSconnect"].ConnectionString; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");        }

      //  protected void SignOut_Click(object sender, EventArgs e)
       // {
          //  Session.Abandon();
        //    Response.Redirect("LogIn.aspx");
       // }

        protected void Registration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void DailyRecord_Click(object sender, EventArgs e)
        {
            Response.Redirect("DailyRecord.aspx");
        }
    }
}
