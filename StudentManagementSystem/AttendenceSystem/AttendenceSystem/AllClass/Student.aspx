<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="AttendenceSystem.AllClass.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table style="width: 1500px; height: 918px; margin-right: 222px;">
        <tr>
            <td style="width: 124px">
                STudent ID
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="txtsid" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="height: 22px; width: 124px">
                Student Name
            </td>
            <td style="height: 22px; width: 1035px;">
                <asp:TextBox ID="txtSname" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Address
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="txtaddress" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Contact No
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="txtContactNo" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 124px">
                Email
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TextEmail" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="height: 22px; width: 124px">
                Varsity
            </td>
            <td style="height: 22px; width: 1035px;">
                <asp:TextBox ID="txtVarsity"  runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Course
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TxtCourse" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Fees
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TextFees" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Fees Paid
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TextFeesPaid" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="height: 22px; width: 124px">
                Teacher
            </td>
            <td style="height: 22px; width: 1035px;">
                <asp:TextBox ID="TxtTeacher" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                Year
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TxtYear" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                StartDate
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TxtStartDate" placeholder="YY/MM/DD" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 124px">
                End Date
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TextEndDate" placeholder="YY/MM/DD" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="height: 22px; width: 124px">
                Entry Date
            </td>
            <td style="height: 22px; width: 1035px;">
                <asp:TextBox ID="TextEntryDate" placeholder="YY/MM/DD" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>


        <tr>
            <td style="width: 124px">
                UpdateDate
            </td>
            <td style="width: 1035px">
                <asp:TextBox ID="TexUpdateDate" placeholder="YY/MM/DD" runat="server" Height="44px" Width="420px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            
            <td style="width: 124px">
                <asp:Button ID="txtSinsert" style ="background-color:#4a148c; color:white" runat="server" Text="Add Student" Height="40px" Width="332px" OnClick="txtinsert_Click" />
            </td>
        </tr>
        
    </table>

    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="241px" Width="1500px" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="SID">
                
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="StudentName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("StudentName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("StudentName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ContactNo">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("ContactNo") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("ContactNo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Varsity">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Varsity") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Varsity") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Course") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Course") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fees">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("Fees") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("Fees") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FeesPaid">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("FeesPaid") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("FeesPaid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Teacher">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("Teacher") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label10" runat="server" Text='<%# Bind("Teacher") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Year">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("Year") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Bind("Year") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="StartDate">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("StartDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label12" runat="server" Text='<%# Bind("StartDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EndDate">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox13" runat="server" Text='<%# Bind("EndDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label13" runat="server" Text='<%# Bind("EndDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="EntryDate" HeaderText="EntryDate" />
            <asp:TemplateField HeaderText="UpdateDate">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox14" runat="server" Text='<%# Bind("UpdateDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label14" runat="server" Text='<%# Bind("UpdateDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
</asp:Content>
