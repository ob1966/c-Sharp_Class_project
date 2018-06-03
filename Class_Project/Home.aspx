<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        h1 {
            font-family: verdana;
            font-size: 20px;
            color: white;
            background-color:#507CD1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Welcome to the C# Final Project</h1>  
</asp:Content>

