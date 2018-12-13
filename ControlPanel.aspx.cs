using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ControlPanel : System.Web.UI.Page
{
    string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
 

    protected void Page_Load(object sender, EventArgs e)
    {

        
        using (SqlConnection conn = new SqlConnection(constr))


        {


            try
            {
                conn.Open();
                using (SqlCommand cmd1 = new SqlCommand("SELECT count(powerStat)FROM dbo.status where powerStat = '1'", conn))
                {
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        reader.Read();
                        int numRec1 = Convert.ToInt32(reader[0]);
                        lblpowerStat.Text = numRec1.ToString();

                        if (lblpowerStat.Text != "0")
                        {

                            imgbtnPowGreen.Visible = true;
                            imgbtnPowBlue.Visible = false;
                            lblStstus.Text = "Power ON";


                        }
                        else
                        {
                            imgbtnPowBlue.Visible = true;
                            imgbtnPowGreen.Visible = false;
                            lblStstus.Text = "Power OFF";
                        }

                        reader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            

           

        }

    }
    protected void panelRead_Tick(object sender, EventArgs e)
    {
       
        using (SqlConnection conn = new SqlConnection(constr))
        {


          conn.Open();

        
  //===============================================================================================================
          using (SqlCommand cmd1 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94776070767' ", conn))
          {
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    reader.Read();


                    lbl_flag1.Text = reader[0].ToString();


                    if (lbl_flag1.Text.Contains("0"))
                    {
                        lbl_InActive1.Visible = true;
                        lbl_Active1.Visible = false;
                    }
                    else
                    {
                        lbl_Active1.Visible = true;
                        lbl_InActive1.Visible = false;
                    }

                    reader.Close();

                }


          }
            
          //===============================================================================================================

          using (SqlCommand cmd2 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94779635777' ", conn))
          {
              using (SqlDataReader reader = cmd2.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag2.Text = reader[0].ToString();

                  if (lbl_flag2.Text.Contains("0"))
                  {
                      lbl_InActive2.Visible = true;
                      lbl_Active2.Visible = false;
                  }
                  else
                  {
                      lbl_Active2.Visible = true;
                      lbl_InActive2.Visible = false;
                  }

                  reader.Close();

              }
          }

        ////    //==========================================================================


          using (SqlCommand cmd3 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94764964475' ", conn))
         {
             using (SqlDataReader reader = cmd3.ExecuteReader())
             {
                 reader.Read();


                 lbl_flag3.Text = reader[0].ToString();

                 if (lbl_flag3.Text.Contains("0"))
                 {
                     lbl_InActive3.Visible = true;
                     lbl_Active3.Visible = false;
                 }
                 else
                 {
                     lbl_Active3.Visible = true;
                     lbl_InActive3.Visible = false;
                 }

                 reader.Close();

             }
         }

        ////    //=====================================================================


        ////    //==========================================================================


          using (SqlCommand cmd4 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94764954475' ", conn))
          {
              using (SqlDataReader reader = cmd4.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag4.Text = reader[0].ToString();

                  if (lbl_flag4.Text.Contains("0"))
                  {
                      lbl_InActive4.Visible = true;
                      lbl_Active4.Visible = false;
                  }
                  else
                  {
                      lbl_Active4.Visible = true;
                      lbl_InActive4.Visible = false;
                  }

                  reader.Close();

              }
          }

       //=====================================================================


          using (SqlCommand cmd5 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94764974475' ", conn))
          {
              using (SqlDataReader reader = cmd5.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag5.Text = reader[0].ToString();

                  if (lbl_flag5.Text.Contains("0"))
                  {
                      lbl_InActive5.Visible = true;
                      lbl_Active5.Visible = false;
                  }
                  else
                  {
                      lbl_Active5.Visible = true;
                      lbl_InActive5.Visible = false;
                  }

                  reader.Close();

              }
          }

  //==========================================================================


          using (SqlCommand cmd6 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94764944475' ", conn))
          {
              using (SqlDataReader reader = cmd6.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag6.Text = reader[0].ToString();

                  if (lbl_flag6.Text.Contains("0"))
                  {
                      lbl_InActive6.Visible = true;
                      lbl_Active6.Visible = false;
                  }
                  else
                  {
                      lbl_Active6.Visible = true;
                      lbl_InActive6.Visible = false;
                  }

                  reader.Close();

              }
          }

  //=====================================================================



          using (SqlCommand cmd7 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94764944475' ", conn))
          {
              using (SqlDataReader reader = cmd7.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag7.Text = reader[0].ToString();

                  if (lbl_flag7.Text.Contains("0"))
                  {
                      lbl_InActive7.Visible = true;
                      lbl_Active7.Visible = false;
                  }
                  else
                  {
                      lbl_Active7.Visible = true;
                      lbl_InActive7.Visible = false;
                  }

                  reader.Close();

              }
          }



//==========================================================================


          using (SqlCommand cmd8 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94718528178' ", conn))
          {
              using (SqlDataReader reader = cmd8.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag8.Text = reader[0].ToString();

                  if (lbl_flag8.Text.Contains("0"))
                  {
                      lbl_InActive8.Visible = true;
                      lbl_Active8.Visible = false;
                  }
                  else
                  {
                      lbl_Active8.Visible = true;
                      lbl_InActive8.Visible = false;
                  }

                  reader.Close();

              }
          }

  //=====================================================================




          using (SqlCommand cmd9 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94766280008' ", conn))
          {
              using (SqlDataReader reader = cmd9.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag9.Text = reader[0].ToString();

                  if (lbl_flag9.Text.Contains("0"))
                  {
                      lbl_InActive9.Visible = true;
                      lbl_Active9.Visible = false;
                  }
                  else
                  {
                      lbl_Active9.Visible = true;
                      lbl_InActive9.Visible = false;
                  }

                  reader.Close();

              }
          }



        //    //==========================================================================


          using (SqlCommand cmd10 = new SqlCommand("SELECT powerStat FROM dbo.status where devid ='94766280009' ", conn))
          {
              using (SqlDataReader reader = cmd10.ExecuteReader())
              {
                  reader.Read();


                  lbl_flag10.Text = reader[0].ToString();

                  if (lbl_flag10.Text.Contains("0"))
                  {
                      lbl_InActive10.Visible = true;
                      lbl_Active10.Visible = false;
                  }
                  else
                  {
                      lbl_Active10.Visible = true;
                      lbl_InActive10.Visible = false;
                  }

                  reader.Close();

              }
          }

        //    //=====================================================================



       conn.Close();

        }
    }

    protected void imgbtnPowBlue_Click(object sender, ImageClickEventArgs e)
    {

        imgbtnPowBlue.Visible = false;
        lblStstus.Text = "Processing...";
        imgbtnPowRed.Visible = true;
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94764964475'", conn))
                {
                  
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
                throw;
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94779635777'", conn))
                {
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94764974475'", conn))
                {
                   
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94764954475'", conn))
                {
                 
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
               
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);

        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94764944475'", conn))
                {
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94718528178'", conn))
                {
                   
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94766280008'", conn))
                {
                  
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94766280009'", conn))
                {
                    cmd.Parameters.AddWithValue("@currentFlag", "1");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94766280010'", conn))
                {
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = '1', powFlag = '1', currentFlag = '1' where devid = '94776070767'", conn))
                {
                   
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        System.Threading.Thread.Sleep(2000);

        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94766280011'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94766280012'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94766280013'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94767799364'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94775741015'", conn))//
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94769238757'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94769841767'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94773293913'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94776070767'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}
        //System.Threading.Thread.Sleep(2000);
        //using (SqlConnection conn = new SqlConnection(constr))
        //{
        //    conn.Open();
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat where devid = '94776702283'", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@powerStat", "1");
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception )
        //    {
        //    }
        //    conn.Close();
        //}

        imgbtnPowRed.Visible = false;
        lblStstus.Text = "Power ON";
        imgbtnPowGreen.Visible = true;
    }

    protected void imgbtnPowGreen_Click(object sender, ImageClickEventArgs e)
    {

        imgbtnPowGreen.Visible = false;
        lblStstus.Text = "Power OFF";
        imgbtnPowBlue.Visible = true;

        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94779635777'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94764964475'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94764954475'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94764974475'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94764944475'", conn))//
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94718528178'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94766280008'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94766280009'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94766280010'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }
        System.Threading.Thread.Sleep(2000);
        using (SqlConnection conn = new SqlConnection(constr))
        {
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE status SET powerStat = @powerStat, currentFlag = @currentFlag where devid = '94776070767'", conn))
                {
                    cmd.Parameters.AddWithValue("@powerStat", "0");
                    cmd.Parameters.AddWithValue("@currentFlag", "0");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
            }
            conn.Close();
        }

       
    }

    protected void imgbtnPowRed_Click(object sender, ImageClickEventArgs e)
    {

    }


}