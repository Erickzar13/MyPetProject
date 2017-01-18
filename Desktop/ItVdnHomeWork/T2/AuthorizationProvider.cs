using System.Web;

namespace T2
{
    public static class AuthorizationProvider
    {
        public static bool CheckUserLoginPassword(string login, string password)
        {
            bool result = login=="test" && password == "test" || ChecCookies(login);

            return result;
        }

        public static void SignatureGenerator(string login)
        {
            HttpContext.Current.Response.Cookies.Add(new HttpCookie("name", login));
            HttpContext.Current.Response.Cookies.Add(
                new HttpCookie("sign", CryptoProvider.GetMd5Hash(login + "s@lt")));
        }

        private static bool ChecCookies(string login)
        {
            return HttpContext.Current.Request.Cookies["name"] != null
                   && HttpContext.Current.Request.Cookies["sign"] != null
                   && HttpContext.Current.Request.Cookies["name"].ToString() == login
                   && HttpContext.Current.Request.Cookies["sign"].ToString() == CryptoProvider.GetMd5Hash(login);
        }

    }
}