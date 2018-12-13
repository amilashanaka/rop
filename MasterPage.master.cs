using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate.Text = DateTime.Now.ToString("dd/mm/yyyy");
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        //string Loc = "";
        //HttpCookie cook = new HttpCookie(Loc);
    }
    //protected void btn_Link_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("ControlPanel.aspx");
    //}
    //protected void btn_Home_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Default.aspx");
    //}
    protected void btn_Front_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
