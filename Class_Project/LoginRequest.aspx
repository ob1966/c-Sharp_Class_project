<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="LoginRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery-3.3.1.intellisense.js"></script>
    <script type ="text/javascript">
        $(document).ready(function () {
            $("#<%=tbDatePicker.ClientID%>").datepicker();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbName" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lnEmail" runat="server" Text="Email"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbLoginName" runat="server" Text="Login"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbLoginName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbNeedByDate" runat="server" Text="Date Needed By"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbDatePicker" runat="server"></asp:TextBox>
</asp:Content>


