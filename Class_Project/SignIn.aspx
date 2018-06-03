﻿<%@ Page Title="Sign In" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" Trace="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .Label {
            font-family: verdana;
        }

        .Button {
            background-color: blue;
            border: none;
            color: white;
            padding: 10px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 12px;
            margin: 4px 2px;
            cursor: pointer;
        }

        .LinkButton {
            color: blue;
            font-family: 'Times New Roman', Times, serif;
            font-style: italic;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
       <asp:ValidationSummary runat="server"
        HeaderText="There were errors on the page:"
        ForeColor="Red" />

    <asp:Label ID="LbUserName" runat="server" Text="User Name" CssClass="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbUserName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ErrorMessage="User Name Is Required"
        ControlToValidate="TbUserName" CausesValidation="false"
        ForeColor="Red" Text="*" SetFocusOnError="True">
    </asp:RequiredFieldValidator>

    <br />

    <asp:Label ID="LbPassword" runat="server" Text="Password" CssClass="Label"></asp:Label>
    &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ErrorMessage="A password is required"
        ControlToValidate="TbPassword" CausesValidation="false"
        ForeColor="Red" Text="*" SetFocusOnError="True">
    </asp:RequiredFieldValidator>

    <br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtSignIn" runat="server" Text="Sign In" OnClick="BtSignIn_Click" CssClass="Button" />

    <br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LbtRequestLogin" runat="server" OnClick="LbtRequestLogin_Click" CssClass="LinkButton">Request Login Account</asp:LinkButton>
</asp:Content>

