<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="S.web.Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 398px;
            border: 5px solid #800000;
            background-color: #0000FF;
        }
        .auto-style2 {
            width: 227px;
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
                        <asp:Label ID="lblHeader" runat="server" Text="Course Table"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dropDownDepartment" runat="server" Height="16px" Width="227px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCourseCode" runat="server" Text="Course Code"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCourseCode" runat="server" Width="218px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCourseName" runat="server" Text="Course Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCourseName" runat="server" Width="218px"></asp:TextBox>
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
