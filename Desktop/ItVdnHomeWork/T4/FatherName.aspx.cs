using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T4
{
    public partial class FatherName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            Session["Key"] += txbFatherName.Text;
            Response.Redirect("Result.aspx");
        }
    }
}