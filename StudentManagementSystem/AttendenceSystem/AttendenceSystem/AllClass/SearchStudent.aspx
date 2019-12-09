<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="AttendenceSystem.AllClass.SearchStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 663px; height: 305px">
        <tr>
         <td>
            YEAR 
        </td>
            <td>
                <asp:TextBox ID="TxtYear" runat="server" Height="44px" Width="244px"></asp:TextBox>
            </td>
             <td>
                <asp:Button ID="Button1" class="btn btn-primary btn-lg btn-block" runat="server" Text="Search" Height="49px" Width="168px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
           <td style="height: 76px">
               Teacher
           </td>
            <td style="height: 76px">
                 <asp:TextBox ID="TxtTeacher" runat="server" Height="44px" Width="244px"></asp:TextBox>
            </td>
            <td style="height: 76px">
                <asp:Button ID="Button2" class="btn btn-primary btn-lg btn-block" runat="server" Text="Search" Height="49px" Width="166px" OnClick="Button2_Click"/>
            </td>
        </tr>

          <tr>
           <td>
               Sudent
           </td>
            <td>
                 <asp:TextBox ID="TexStudent" runat="server" Height="44px" Width="244px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button3" class="btn btn-primary btn-lg btn-block" runat="server" Text="Search" Height="49px"  Width="165px" OnClick="Button3_Click" />
            </td>
        </tr>
          <tr>
           <td>
               Fees
           </td>
            <td>
                 <asp:TextBox ID="TxtFees" runat="server" Height="44px" Width="244px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button4" class="btn btn-primary btn-lg btn-block" runat="server" Text="Search" Height="49px" Width="163px" OnClick="Button4_Click"/>
            </td>
        </tr>
    </table>
        
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="162px" Width="1331px">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>
</asp:Content>
