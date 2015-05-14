using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Trace.Warn("Render", "Text is about to render.");

            //System.Web.UI.Page page = HttpContext.Current.CurrentHandler as System.Web.UI.Page;
            //System.Web.UI.ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('You do not have access to this page. You are being redirected')", true);
        }
    }
}