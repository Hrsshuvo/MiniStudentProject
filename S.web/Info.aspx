<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="S.web.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 448px;
            border: 5px solid #00FFFF;
            background-color: #00FF00;
        }
        .auto-style2 {
            width: 248px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td colspan="2" class="auto-style3">
                        <asp:Label ID="lblHeader" runat="server" Text="Student Information"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRoll" runat="server" Text="Roll"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dropdownRoll" runat="server" Height="16px" Width="284px" AutoPostBack="true" OnSelectedIndexChanged="dropdownRoll_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server" Width="273px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtdepartment" runat="server" Width="273px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCourse" runat="server" Text="Course"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCourse" runat="server" Width="273px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="lblMessege" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
