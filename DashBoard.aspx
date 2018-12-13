<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DashBoard.aspx.cs" Inherits="DashBoard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style13
        {
            width: 99%;

        }
        .style14
        {
            width: 33%;
        }

        </style>

    
</head>
<body>
    <form id="form1" runat="server">

    <div id="gauges">

        <table width="100%">
            <tr>
                <td width="50%">
                    <b>RO Plant Status : </b><asp:Label ID="lblPlantStatus" runat="server" Text="" Font-Bold="True" Visible="false"></asp:Label><asp:Label ID="lblActive" runat="server" Text="ACTIVE" Font-Bold="True" ForeColor="Green" Visible="false" ></asp:Label><asp:Label ID="lblInActive" runat="server" Text="INACTIVE" ForeColor="Red" Font-Bold="True" Visible="false"></asp:Label></td>
                <td width="50%">
<b>Location : </b><asp:Label ID="lblLocation" runat="server" Text="" Font-Bold="True"></asp:Label><asp:TextBox ID="txtLoc" runat="server" Visible="false"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Panel ID="gg1Panel" runat="server">
<table class="style13">
        <tr>
            <td class="style14"><center>
 <div id="gg1" class="gauge" ></div>
 

  <script src="js/raphael-2.1.4.min.js" type="text/javascript"></script>
  <script src="js/justgage.js" type="text/javascript"></script>
  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg1 = new JustGage({
              id: "gg1",
              value: document.getElementById('<%=txtpH.ClientID%>').value,
              min: 0,
              max: 15.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "red",
                  lo: 0.0,
                  hi: 5.0
              }, {
                  color: "yellow",
                  lo: 5.0,
                  hi: 6.0
              }, {
                  color: "green",
                  lo: 6.5,
                  hi: 8.0
              }, {
                  color: "yellow",
                  lo: 8.5,
                  hi: 9.5
              }, {
                  color: "red",
                  lo: 9.5,
                  hi: 15.0
              }],
              counter: true
          });

      });
  </script><b>PH Value</b></center></td>
            <td class="style14">
             
             <center>
    <div id="gg2" class="gauge"></div>

  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg2 = new JustGage({
              id: "gg2",
              value: document.getElementById('<%=txtConductivity.ClientID%>').value,
              min: 0,
              max: 300.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "red",
                  lo: 0.0,
                  hi: 179.5
              }, {
                  color: "yellow",
                  lo: 180.0,
                  hi: 195.5
              }, {
                  color: "green",
                  lo: 200.0,
                  hi: 230.0
              }, {
                  color: "yellow",
                  lo: 230.5,
                  hi: 250.0
              }, {
                  color: "red",
                  lo: 250.5,
                  hi: 300.0
              }],
              counter: true
          });

      });
  </script><b>Conductivity</b>
                 </center>   
                    </td>
            <td>
              <center>

    <div id="gg3" class="gauge"></div>

  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg3 = new JustGage({
              id: "gg3",
              value: document.getElementById('<%=txtTDS.ClientID%>').value,
              min: 0,
              max: 300.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "red",
                  lo: 0.0,
                  hi: 179.5
              }, {
                  color: "yellow",
                  lo: 180.0,
                  hi: 195.5
              }, {
                  color: "green",
                  lo: 200.0,
                  hi: 230.0
              }, {
                  color: "yellow",
                  lo: 230.5,
                  hi: 250.0
              }, {
                  color: "red",
                  lo: 250.5,
                  hi: 300.0
              }],
              counter: true
          });

      });
  </script><b>TDS</b></center>
                    
                    </td>
        </tr>
        <tr>
            <td class="style14">
                             <center>

    <div id="gg4" class="gauge"></div>

  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg4 = new JustGage({
              id: "gg4",
              value: document.getElementById('<%=txtTemperature.ClientID%>').value,
              min: 0,
              max: 80.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [ {
                  color: "green",
                  lo: 0.0,
                  hi: 40.0
              }, {
                  color: "yellow",
                  lo: 40.0,
                  hi: 50.0
              }, {
                  color: "red",
                  lo: 50.0,
                  hi: 80.0
              }],
              counter: true
          });

      });
  </script><b>Temperature °C</b></center></td>
            <td class="style14">
                             <center>

    <div id="gg5" class="gauge"></div>

  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg5 = new JustGage({
              id: "gg5",
              value: document.getElementById('<%=txtSallinity.ClientID%>').value,
              min: 0,
              max: 100.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "green",
                  lo: 0.0,
                  hi: 100.0
              }],
              counter: true
          });

      });
  </script><b>Flow Rate</b></center></td>
            <td>
                              <center>

    <div id="gg6" class="gauge"></div>

  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg6 = new JustGage({
              id: "gg6",
              value: 0,
              min: 0,
              max: 300.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "green",
                  lo: 0.0,
                  hi: 10.0
              }],
              counter: true
          });

      });
  </script><b>Sallinity</b></center></td>
        </tr>
    </table>
    </asp:Panel>
</div>  

  <div id="hidden" style="visibility:hidden;">
    <asp:TextBox ID="txtpH" runat="server"/><asp:TextBox ID="txtConductivity" runat="server"/><asp:TextBox ID="txtTDS" runat="server"/><asp:TextBox ID="txtTemperature" runat="server"/><asp:TextBox ID="txtWaterFlowRate" runat="server"/><asp:TextBox ID="txtSallinity" runat="server"/>
    </div>
    </form>
    
</body>

</html>
