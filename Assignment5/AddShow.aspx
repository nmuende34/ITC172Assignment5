<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddShow.aspx.cs" Inherits="AddShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Shows</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style3 {
            width: 96px;
        }
        .auto-style4 {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add Show</h1>
        <table id="TableArtist" runat="server">
            <tr>
                <td class="auto-style4">Artist Name</td>
                <td class="auto-style2">
                    <asp:TextBox id="txtArtistName" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox></td>
            </tr>
              <tr>
                <td class="auto-style4">Artist Email</td>
                <td class="auto-style2">
                    <asp:TextBox id="txtArtistEmail" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox></td>
            </tr>
              <tr>
                <td class="auto-style4">Artist WebSite</td>
                <td class="auto-style2">
                    <asp:TextBox id="txtWebSite" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox></td>
            </tr>
              <tr>
                <td class="auto-style4">
                    <asp:Button id="btnAddArtist" runat="server" Text="Save"  OnClick="btnAddArtist_Click" Width="95px"/></td>
                <td class="auto-style2">
                    <asp:Label id="Label1" runat="server" Text="Save the artist before adding show information"></asp:Label>
                    </td>
            </tr>
        </table>
        <p>Select your artist.  <asp:DropDownList id="DropDownListArtist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListArtist_SelectedIndexChanged"></asp:DropDownList> </p>
        <table id="Table1" runat="server">
            <tr>
                <td class="auto-style3">
                    Show Name
                </td>
                <td>
                    <asp:TextBox id="txtShowName" class="txtbox" runat="server" Width="209px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    Show Date
                </td>
                <td>
                    <asp:Calendar id="Calendar1" runat="server" ></asp:Calendar> 
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    Show Time (military 12:00:00)
                </td>
                <td>
                    <asp:TextBox id="txtTime" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    Show ticket info
                </td>
                <td>
                    <asp:TextBox id="txtInfo" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td id="artistKey1" class="auto-style3">
                    Artist Key
                </td>
                <td id="artistKey2">
                    <asp:Label id="lblArtistKey" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    Artist Start Time (military 12:00:00)
                </td>
                <td>
                    <asp:TextBox id="txtArtistStart" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                   Additional Information
                </td>
                <td>
                    <asp:TextBox id="txtAdditional" class="txtbox" runat="server" Width="209px" Height="23px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    <asp:Button id="btnShow" runat="server" Text="Add Show" OnClick="btnShow_Click" Width="94px" />  
                </td>
                <td>
                    <asp:Label id="lblResult" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <asp:LinkButton id="LinkButton2" runat="server" PostBackUrl="~/AddShow.aspx" CausesValidation="false" >Add Another Show</asp:LinkButton>&nbsp; 
        <asp:LinkButton id="LinkButton3" runat="server" PostBackUrl="~/AddShow.aspx" CausesValidation="false" OnClick="LinkButton3_Click" >Log Out</asp:LinkButton></p>
    </div>
    </form>
</body>
</html>