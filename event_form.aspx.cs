using System;
using System.Web.UI;

namespace practical_4_114
{
    public partial class event_form : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("<h2>Registration Successful!</h2>");
        }
    }
}