<%@ Page Title="Registration" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="ClassRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="ProjectCSS.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:ValidationSummary runat="server"
            ForeColor="Red" />
    </div>
    <p>Enter a class ID number and find your class.</p>
    <asp:TextBox ID="TbClassID" runat="server" Width="26px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ErrorMessage="Class ID Number Is Required"
        ControlToValidate="TbClassID" CausesValidation="false"
        ForeColor="Red" Text="*" SetFocusOnError="True">
    </asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="BtFindClass" runat="server" Text="Find Class" OnClick="BtFindClass_Click" Class="Button" />
    <asp:HiddenField ID="HiddenFieldClassID" runat="server" />
    <br />
    <asp:Button ID="BtRegister" runat="server" Text="Register" OnClick="BtRegister_Click" />
    <asp:Label ID="LbClass" runat="server"></asp:Label>
</asp:Content>

