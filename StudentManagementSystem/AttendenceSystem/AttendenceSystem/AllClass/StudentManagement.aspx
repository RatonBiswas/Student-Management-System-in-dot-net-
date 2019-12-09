<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentManagement.aspx.cs" Inherits="AttendenceSystem.AllClass.StudentManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #FF0066;
            text-align: center;
        }
        .auto-style2 {
            position: relative;
            left: 49px;
            top: 147px;
            background-color: #990099;
        }
        .auto-style3 {
            position: relative;
            left: 91px;
            top: 145px;
            background-color: #333333;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <p class="auto-style1">
                <strong>Student Management System</strong></p>
            <asp:Button ID="Admin" runat="server" CssClass="auto-style2" ForeColor="White" Height="104px" OnClick="Admin_Click" Text="Admin" Width="340px" />
            <asp:Button ID="Button2" runat="server" BorderStyle="Double" CssClass="auto-style3" ForeColor="White" Height="104px" OnClick="Button2_Click" Text="User" Width="340px" />
        </div>
    </form>
</body>
</html>
