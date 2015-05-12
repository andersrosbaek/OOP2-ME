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


            //output.Write("Welcome to Control Development!<br>");

            //// Test if the page is loaded for the first time 
            //if (!Page.IsPostBack)
            //    output.Write("Page has just been loaded");
            //else
            //    output.Write("Postback has occured");


          //  Trace.WriteLine("ASP.NET TRACE", "page_load called.");

            //// Create a trace listener for the event log.
            //EventLogTraceListener myTraceListener = new EventLogTraceListener("myEventLogSource");

            //// Add the event log trace listener to the collection.
            //Trace.Listeners.Add(myTraceListener);

            //// Write output to the event log.
            //Trace.WriteLine("Test output");
        }
    }
}