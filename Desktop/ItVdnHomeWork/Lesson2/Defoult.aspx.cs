using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson2
{
    public partial class Defoult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var item in Request.QueryString.AllKeys)
            {
                Label1.Text += item;
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {


        }
    }
}