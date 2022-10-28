using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication15
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string line = "";
            string imageURL = "";

            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(HttpContext.Current.Server.MapPath("~/Images/" + FileUpload1.FileName));
                imageURL = "/Images/" + FileUpload1.FileName;
            }
            else
            {
                Label1.Text = "Nema slike";
            }
            line = TextBox1.Text + "|" + TextBox2.Text + "|" + TextBox3.Text + "|" + imageURL;
            Cvet.DodajNovi(line);
        }
    }
}