<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lnUserName" runat="server" Text="User Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbPassword" runat="server" Text="Password"></asp:Label>
    &nbsp; &nbsp;&nbsp;
    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btSignIn" runat="server" Text="Sign In" />
    <br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lbtRequestLogIn" runat="server" OnClick="lbtRequestLogIn_Click">Request Login Account</asp:LinkButton>
    <br />

</asp:Content>

