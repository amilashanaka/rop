using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Gauge : System.Web.UI.Page
{
    string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    SqlConnection con = null;
    SqlCommand cmd = null;
    SqlDataAdapter ddt = new SqlDataAdapter();
    DataSet dtd = new DataSet();
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(constr);
        con.Open();

        cmd = new SqlCommand("SELECT top 1 ph FROM dbo.data a INNER JOIN dbo.device b ON b.DeviceId = divid WHERE [divid] = '94773293913' ORDER BY id DESC", con);

        cmd.Connection = con;
        ddt.SelectCommand = cmd;
        ddt.Fill(dtd, "0");

        string phm = dtd.Tables[0].Rows[i][0].ToString();


        //txtdirection.Text = phm;

        con.Close();
    }
}