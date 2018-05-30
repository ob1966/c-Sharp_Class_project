<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="LoginRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ValidationSummary runat="server"
        HeaderText="There were errors on the page:"
        ForeColor="Red" />
    <asp:Label ID="LbName" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbUserName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ErrorMessage="Your Name Is Required"
        ControlToValidate="TbUserName" CausesValidation="false"
        ForeColor="Red" Text="*" SetFocusOnError="True">
    </asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LbEmail" runat="server" Text="Email"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ErrorMessage="Email Required"
        ControlToValidate="TbEmail" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
        ControlToValidate="TbEmail" CausesValidation="false"
        ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        ErrorMessage="Must use a valid email address." Text="*"> <!-- Source: http://regexlib.com/Search.aspx?k=email&AspxAutoDetectCookieSupport=1 -->
    </asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="LbLoginName" runat="server" Text="Login"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbLoginName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
        ErrorMessage="User Name Required"
        ControlToValidate="TbLoginName" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>
    <br />
    <asp:RadioButtonList ID="RadioButtonListAccount" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Selected="True">New</asp:ListItem>
        <asp:ListItem>Reactivate</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="LbNeedByDate" runat="server" Text="Date Needed By"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbDatePicker" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
        ErrorMessage="Need By Date Required"
        ControlToValidate="TbDatePicker" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LbReason" runat="server" Text="Reason For Access"></asp:Label>
    <br />
    <asp:TextBox ID="TbMessage" runat="server" MaxLength="50"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
        ErrorMessage="Need By Date Required"
        ControlToValidate="TbMessage" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>
    <br />
    <asp:LinkButton ID="TbtSubmitRequest" runat="server" OnClick="TbtSubmitRequest_Click">Submit Request</asp:LinkButton>
    <br />
    <asp:Label ID="LbSuccessMessage" runat="server"></asp:Label>
</asp:Content>


