using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson2Part2
{
    public partial class Defoult : System.Web.UI.Page
    {
        private string result;
        private StreamReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            reader = new StreamReader(@"D:\PetProj\Desktop\ItVdnHomeWork\Lesson2Part2\Text.txt");

            result = reader.ReadToEnd();
        }


        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = result;
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            reader.Close();

        }
    }
}