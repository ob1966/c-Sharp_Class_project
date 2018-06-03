<%@ Page Title="My Classes" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyClasses.aspx.cs" Inherits="MyClasses" Trace="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="ProjectCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="RetrieveMyClasses" TypeName="AppControl">
        <SelectParameters>
            <asp:FormParameter DefaultValue="0" FormField="AuthenticatedUser" Name="studentId" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

