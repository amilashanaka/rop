<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp" type="text/javascript"></script>
    <style type="text/css">
        #map-canvas
        {
            height: 126%;
            margin: 0px;
            padding: 0px;
        }
    </style>
     
    <script type="text/javascript">

        var map;
        function initialize() {
            var mapOptions = {
                zoom: 7,
                center: new google.maps.LatLng(7.832225, 80.557752)
            };

            var map = new google.maps.Map(document.getElementById('map-canvas'),
      mapOptions);

            var marker1 = new google.maps.Marker({
                position: new google.maps.LatLng(7.4677209, 80.6240543),
                map: map,
                title: 'Naminioya'


            });

            var marker2 = new google.maps.Marker({
                position: new google.maps.LatLng(7.5873562, 80.9561353),
                map: map,
                title: 'Maraka'
            } );

            var marker3 = new google.maps.Marker({
                position: new google.maps.LatLng(7.4989076, 80.9231348),
                map: map,
                title: 'Nugagolla'
            } );

            var marker4 = new google.maps.Marker({
                position: new google.maps.LatLng(7.5790325, 80.9647399),
                map: map,
                title: 'Malgammana '
            } );
            var marker5 = new google.maps.Marker({
                position: new google.maps.LatLng(7.50476961, 80.9438324),
                map: map,
                title: 'MAHATHANNA P.S'
            });
            var marker6 = new google.maps.Marker({
                position: new google.maps.LatLng(7.54152929, 80.91773987),
                map: map,
                title: 'RADUNNEWEWA P.S'
            });
            var marker7 = new google.maps.Marker({
                position: new google.maps.LatLng(7.50204654, 80.93421936),
                map: map,
                title: 'SONUTTARA K.V'
            });
            var marker8 = new google.maps.Marker({
                position: new google.maps.LatLng(7.50476961, 80.95344553),
                map: map,
                title: ' BOGAHAWEWA K.V'
            });
            var marker9 = new google.maps.Marker({
                position: new google.maps.LatLng(7.51430019, 80.92735291),
                map: map,
                title: ' DHARMAPALA P.S'
            });
            var marker10 = new google.maps.Marker({
                position: new google.maps.LatLng(7, 55378183, 80.96031189),
                map: map,
                title: 'WILGAMUWA P.S'
            });

            google.maps.event.addListener(marker1, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 1;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="ControlPanel.aspx?Loc=1002"></object>';
            });


            google.maps.event.addListener(marker2, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 2;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1003"></object>';
            });

            google.maps.event.addListener(marker3, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 3;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1004"></object>';
            });

            google.maps.event.addListener(marker4, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 4;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker5, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 5;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker6, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 6;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker7, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 7;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker8, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 8;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker9, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 9;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
            google.maps.event.addListener(marker10, 'click', function () {
                (document.getElementById('<%=txtloc.ClientID%>')).value = 10;

                document.getElementById('<%= pnlInfo.ClientID %>').style.visibility = 'visible';
                document.getElementById('<%= pnlInfo.ClientID %>').innerHTML = '<object width="100%" height="100%" type="text/aspx" data="online.aspx?Loc=1005"></object>';
            });
        }

        google.maps.event.addDomListener(window, 'load', initialize);

    </script>
    <title></title>

    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyByZXgbSX4vO8-h3C3LHx0XTdcBaP5Siys&callback=initMap"></script>
</head>
<body>
    <form id="form" runat="server" >
            <asp:Label ID="lbllocation" runat="server">ID: </asp:Label>
    <asp:TextBox ID="txtloc" runat="server" ></asp:TextBox>


    <asp:Panel ID="pnlMap" runat="server" height="340" width="286">
       <div id="map-canvas">   </div>
       </asp:Panel>
    <asp:Panel ID="pnlInfo" runat="server" >
       
    </asp:Panel>
  

    </form>
</body>
</html>

