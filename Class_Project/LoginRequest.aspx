<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="LoginRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="LbName" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbUserName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LbEmail" runat="server" Text="Email"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LbLoginName" runat="server" Text="Login"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbLoginName" runat="server"></asp:TextBox>
    <br />
    <asp:ListBox ID="ListBox2" runat="server" Height="39px">
        <asp:ListItem>New Account</asp:ListItem>
        <asp:ListItem>Reactivate Account</asp:ListItem>
    </asp:ListBox>
    <br />
    <asp:Label ID="LbNeedByDate" runat="server" Text="Date Needed By"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbDatePicker" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LbReason" runat="server" Text="Reason For Access"></asp:Label>
    <br />
    <asp:TextBox ID="TbMessage" runat="server" MaxLength="50"></asp:TextBox>
    <br />
    <asp:LinkButton ID="TbtSubmitRequest" runat="server" OnClick="TbtSubmitRequest_Click">Submit Request</asp:LinkButton>
</asp:Content>


