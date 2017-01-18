using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T2
{
    public partial class Closed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie name = Request.Cookies["name"];
            HttpCookie sign = Request.Cookies["sign"];

            if (name != null && sign != null)
            {
                // Если полученная подпись правильная прекращаем дальнейшую обработку события Load
                // и переходим к следующим этапам жизненного цикла страницы.
                if (sign.Value == CryptoProvider.GetMd5Hash(name.Value + "s@lt"))
                {
                    return;
                }
            }

            Response.Redirect("Login.aspx");
        }
    }
}