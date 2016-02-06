<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTest.aspx.cs" Inherits="proiectBaze.AdminTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 20%;
        }
        .auto-style2 {
            width: 68px;
        }
        .auto-style3 {
            width: 68px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 236px;
        }
        .auto-style5 {
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Nume&nbsp; </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Prenume</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Initiala Tata</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">CNP&nbsp;&nbsp; </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Adresa </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Telefon</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tip </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox7" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Taxa </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox8" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nume Grupa </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox9" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Credite</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox10" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email&nbsp; </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox11" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    </form>
</body>
</html>
