<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="S.web.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 425px;
            border: 5px solid #ff0000;
            background-color: #008080;
        }
        .auto-style2 {
            width: 154px;
        }
        .auto-style3 {
            width: 174px;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style4">
                        <asp:Label ID="lblHeader" runat="server" Text="Department Table" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblCode" runat="server" Text="Code" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCode" runat="server" Width="272px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblDepartment" runat="server" Text="Department" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDepartment" runat="server" Width="272px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style4">
                        <asp:Label ID="lblMessege" runat="server" Text=""></asp:Label>
                        <asp:Button ID="btnSave" runat="server" Text="Save" Font-Bold="True" OnClick="btnSave_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
