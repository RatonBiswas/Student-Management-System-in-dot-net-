<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCourseInfo.aspx.cs" Inherits="AttendenceSystem.UserCourseInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            left: -7px;
            top: 213px;
            height: 108px;
            background-color: #000099;
        }
        .auto-style2 {
            text-align: center;
            height: 91px;
            background-color: #660033;
        }
        .auto-style3 {
            font-size: xx-large;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong><span class="auto-style3">User Area</span></strong><asp:Button ID="Button1" runat="server" CssClass="auto-style1" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Text="Course Information" Width="1212px" />
        </div>
    </form>
</body>
</html>
