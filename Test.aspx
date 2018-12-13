<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="fuelMeterDiv" ></div>

<script type="text/javascript">
	    var $myFuelMeter;
	    $(function () {

	        //y = parseFloat(document.getElementById('<%=txtdirection.ClientID%>').value);
	        // Initialize score meter and slider.
	        $myFuelMeter = $("div#fuelMeterDiv").dynameter({
	            width: 200,
	            label: 'fuel',
	            value: 5.5,
	            min: 0.0,
	            max: 15.0,
	            unit: 'gal',
	            regions: {
	                0: 'error',
	                .5: 'warn',
	                1.5: 'normal'
	            }
	        });

	    });
	</script><asp:Label ID="txtdirection" runat="server" Text="10.0"></asp:Label>
</asp:Content>

