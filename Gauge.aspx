<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gauge.aspx.cs" Inherits="Gauge" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html>

<head>

  <title>Custom Sectors</title>
  <meta name="viewport" content="width=device-width"/>

  <style type="text/css">
  .container {
    width: 450px;
    margin: 0 auto;
    text-align: center;
  }

  .gauge {
    width: 450px;
    height: 450px;
  }

  a:link.button,
  a:active.button,
  a:visited.button,
  a:hover.button {
    margin: 30px 5px 0 2px;
    padding: 7px 13px;
  }

  </style>

</head>


<body>
<form id="form" runat="server">
  <div class="container">
    <div id="gg1" class="gauge"></div>
  </div>

  <script src="js/raphael-2.1.4.min.js" type="text/javascript"></script>
  <script src="js/justgage.js" type="text/javascript"></script>
  <script type="text/javascript">

      document.addEventListener("DOMContentLoaded", function (event) {

          var gg1 = new JustGage({
              id: "gg1",
              value: document.getElementById('<%=txtdirection.ClientID%>').value,
              min: 0,
              max: 15.0,
              decimals: 1,
              gaugeWidthScale: 0.6,
              customSectors: [{
                  color: "red",
                  lo: 0.0,
                  hi: 6.5
              }, {
                  color: "green",
                  lo: 6.5,
                  hi: 8.0
              }, {
                  color: "red",
                  lo: 8.0,
                  hi: 15.0
              }],
              counter: true
          });
  
      });
  </script><asp:TextBox ID="txtdirection" runat="server" Text=""></asp:TextBox>
  </form>
</body>
</html>