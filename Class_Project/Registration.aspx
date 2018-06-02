<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="ClassRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="LbClassID" runat="server" Text="Class ID"></asp:Label>
    <asp:TextBox ID="TbClassID" runat="server"></asp:TextBox>
    <asp:Button ID="BtFindClass" runat="server" Text="Find Class" OnClick="BtFindClass_Click" />
    <asp:HiddenField ID="HiddenFieldClassID" runat="server" />
    <br />
    <asp:Button ID="BtRegister" runat="server" Text="Register" OnClick="BtRegister_Click" />
    <asp:Label ID="LbClass" runat="server"></asp:Label>
</asp:Content>

