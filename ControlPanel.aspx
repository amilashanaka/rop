<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ControlPanel.aspx.cs" Inherits="ControlPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" >
        <tr>
            <td><h4>ROP Status:&nbsp;<asp:Label ID="lblStstus" runat="server" Font-Size="medium" style="" Text=""></asp:Label><asp:Label ID="lblpowerStat" runat="server" Visible="false"></asp:Label></h4></td>
            <td><h4><asp:Label ID="lblLoc"  Text="Location List" runat="server" Font-Bold="True" ></asp:Label></h4></td>
            <td><h4><asp:Label ID="Label2"  Text="Status" runat="server" Font-Bold="True" ></asp:Label></h4></td>
        </tr>
        <tr>
            <td>
<asp:ImageButton ID="imgbtnPowBlue" runat="server" ImageAlign="Middle" ImageUrl="images/Blue.png" style="" onclick="imgbtnPowBlue_Click" Visible="false"/>
<asp:ImageButton ID="imgbtnPowGreen" runat="server" ImageAlign="Middle" ImageUrl="images/Green.png" style="" onclick="imgbtnPowGreen_Click" Visible="false"/>
<asp:ImageButton ID="imgbtnPowRed" runat="server" ImageAlign="Middle" ImageUrl="images/Red.png" style="" onclick="imgbtnPowRed_Click" Visible="false"/>
            </td>
            <td>
            <asp:Label ID="lbl_Location1" runat="server" Text="ශ්‍රී සුදර්ශනාරාමය තිරප්පනය" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location2" runat="server" Text="අ/සෙලෙස්තිමඩුව විද්‍යාලය, තිරප්පනය" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location3" runat="server" Text="ශ්‍රී සුදර්ශනාරාමය, පණ්ඩිතරබවැව, තිරප්පනය " Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location4" runat="server" Text=" තම්මැනා ගල  පුරාණ රජමහා විහාරය, තිරප්පනය " Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location5" runat="server" Text="අ/ හිරියගොලේගම විද්‍යාලය, තලාව" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location6" runat="server" Text="ගම්බිරිගස් වැව, තලාව" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location7" runat="server" Text="ජනසෙත ශ්‍රී පුලිගුවනාරාමය ඉදිගස්පොත, පහල තලාව " Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location8" runat="server" Text="බෞද්ධ මද්‍යස්ථානය, ගල්නෑව , බුල්නෑව" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location9" runat="server" Text="01/A ගම්මානය, අධිරාණිගම,තලාව" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="lbl_Location10" runat="server" Text="නල්ලමුදාව, තලාව " Font-Bold="True"></asp:Label><br />
          <%--  <asp:Label ID="lbl_Location11" runat="server" Text="Pahala Halmillewa Vidyalaya " Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location12" runat="server" Text="Seppukulama" Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location13" runat="server" Text="Hirigollegama vidyalaya" Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location14" runat="server" Text="Gambirigaswewa" Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location15" runat="server" Text="Pahala Talawa" Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location16" runat="server" Text="Galnewa Purana Rajamaha Viharaya" Font-Bold="True"></asp:Label><br />
             <asp:Label ID="lbl_Location17" runat="server" Text="Adhirani Grounds" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location18" runat="server" Text="Nallamudawa" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location19" runat="server" Text="Ruwanweli Central College" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location20" runat="server" Text="Padaviya" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location21" runat="server" Text="Padaviya" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location22" runat="server" Text="Padaviya" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location23" runat="server" Text="Padaviya" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location24" runat="server" Text="Nabadawewa" Font-Bold="True"></asp:Label><br />
              <asp:Label ID="lbl_Location25" runat="server" Text="Sri Swarnabimbaramaya Temple" Font-Bold="True"></asp:Label>--%>

            </td>
            <td>
            <asp:UpdatePanel ID="panelUpdate" runat="server">
            <ContentTemplate>
                            <asp:Timer ID="panelRead" runat="server" Interval="1000" 
                                ontick="panelRead_Tick"></asp:Timer>
                <asp:ScriptManager ID="ScriptManager1" runat="server">   </asp:ScriptManager>
           <asp:Label ID="lbl_flag1" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive1" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active1" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag2" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive2" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active2" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag3" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive3" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active3" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag4" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive4" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active4" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag5" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive5" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active5" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag6" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive6" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active6" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag7" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive7" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active7" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag8" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive8" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active8" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag9" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive9" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active9" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label><br />
            <asp:Label ID="lbl_flag10" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:Label ID="lbl_InActive10" runat="server" Text="InActive" 
                                ForeColor="#CC0000" Visible="false" ></asp:Label>
                            <asp:Label ID="lbl_Active10" runat="server" Text="Active" ForeColor="#009933" 
                                Visible="false" ></asp:Label>
       </ContentTemplate>
       </asp:UpdatePanel>
             
            </td>
        </tr>
    </table>
</asp:Content>

