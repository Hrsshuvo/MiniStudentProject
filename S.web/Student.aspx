<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="S.web.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 464px;
            border: 5px solid #000000;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 274px;
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
                        <asp:Label ID="lblHeader" runat="server" Text="Student Table"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dropdownDepartment" runat="server" Height="16px" Width="275px" OnSelectedIndexChanged="dropdownDepartment_SelectedIndexChanged" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCourse" runat="server" Text="Course"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dropdownCourse" runat="server" Height="16px" Width="275px" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server" Height="20px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRoll" runat="server" Text="Roll"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRoll" runat="server" Height="20px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEmail" runat="server" Height="20px" Width="263px"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="lblMessege" runat="server" Text=""></asp:Label>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
