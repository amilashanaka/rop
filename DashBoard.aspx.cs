using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class DashBoard : System.Web.UI.Page
{
    string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    SqlConnection con = null;
    SqlCommand cmd = null;
    SqlDataAdapter ddt = new SqlDataAdapter();
    DataSet dtd = new DataSet();
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
      
  
                txtLoc.Text = Request.QueryString["Loc"].ToString();
 

        con = new SqlConnection(constr);
        con.Open();

        cmd = new SqlCommand("SELECT top 1 [Location],[time],[ph],[conductivity],[tds],[qty],[temp],s.powerStat FROM dbo.data a INNER JOIN dbo.device b ON b.DeviceId = divid INNER JOIN dbo.status s ON s.devid = b.DeviceId WHERE [divid] = '" + txtLoc.Text + "' ORDER BY id DESC", con);

        cmd.Connection = con;
        ddt.SelectCommand = cmd;
        ddt.Fill(dtd, "0");

        string loc = dtd.Tables[0].Rows[i][0].ToString();
        string pH = dtd.Tables[0].Rows[i][2].ToString();
        string Conductivity = dtd.Tables[0].Rows[i][3].ToString();
        string TDS = dtd.Tables[0].Rows[i][4].ToString();
        string qty = dtd.Tables[0].Rows[i][5].ToString();
        string temp = dtd.Tables[0].Rows[i][6].ToString();
        string active =  dtd.Tables[0].Rows[i][7].ToString();

        lblLocation.Text = loc;
        txtpH.Text = pH;
 
        //lblphValue.Text = pH;
        txtConductivity.Text = Conductivity;
        txtTDS.Text = TDS;
        txtSallinity.Text = qty;
        txtTemperature.Text = temp;
        lblPlantStatus.Text = active;

        if (lblPlantStatus.Text == "1")
        {
            lblActive.Visible = true;
            lblInActive.Visible = false;
            
        }
        if (lblPlantStatus.Text == "0")
        {
            lblInActive.Visible = true;
            lblActive.Visible = false;
            gg1Panel.Visible = false;
        }

        con.Close();

    }
}