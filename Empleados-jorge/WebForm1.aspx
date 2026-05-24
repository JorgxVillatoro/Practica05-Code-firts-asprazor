<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Estudiantes_Jorge.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 505px;
        }
        .auto-style3 {
            width: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>    
                Registro de estudiantes<br />
            </center>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">id</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button6" runat="server" Height="27px" OnClick="Button6_Click" Text="Search" Width="69px" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Genero</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Femenino</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ciudad</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        <center>   
        <asp:Button ID="Button1" runat="server" Text="New" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Show" OnClick="Button5_Click" />
         </center>
        <center>    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            </center>
    </form>
</body>
</html>
