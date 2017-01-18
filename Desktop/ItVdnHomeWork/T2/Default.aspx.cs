using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T2
{
    public partial class Defoult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["name"];

            if (name != null)
            {
                // Прячем ссылку "Вход"
                LoginLink.Visible = false;
                // Отображаем ссылку "Выход"
                LogoutLink.Visible = true;

                LoginLabel.Text = name.Value;
            }

        }
    }
}