<%@ Page Title="Login Request" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="LoginRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="ProjectCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ValidationSummary runat="server"
        HeaderText="There were errors on the page:"
        ForeColor="Red" />
    <asp:Label ID="LbName" runat="server" Text="Name" CssClass="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbUserName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ErrorMessage="Your Name Is Required"
        ControlToValidate="TbUserName" CausesValidation="false"
        ForeColor="Red" Text="*" SetFocusOnError="True">
    </asp:RequiredFieldValidator>

    <br />

    <asp:Label ID="LbEmail" runat="server" Text="Email" CssClass="Label"></asp:Label>
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

    <asp:Label ID="LbLoginName" runat="server" Text="Login" Class="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TbLoginName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
        ErrorMessage="User Name Required"
        ControlToValidate="TbLoginName" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>

    <br />

    <asp:RadioButtonList ID="RadioButtonListAccount" runat="server" RepeatDirection="Horizontal" Height="19px" Width="143px" CssClass="Label">
        <asp:ListItem Selected="True">New</asp:ListItem>
        <asp:ListItem>Reactivate</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="LbNeedByDate" runat="server" Text="Date Needed By" CssClass="Label"></asp:Label>


<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
    <WeekendDayStyle BackColor="#CCCCFF" />
    </asp:Calendar>

    <br />

    <asp:Label ID="LbReason" runat="server" Text="Reason For Access" Class="Label"></asp:Label>

    <br />

    <asp:TextBox ID="TbMessage" runat="server" MaxLength="50" Width="265px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
        ErrorMessage="Need By Date Required"
        ControlToValidate="TbMessage" CausesValidation="false"
        ForeColor="Red" Text="*">
    </asp:RequiredFieldValidator>

    <br />

    <asp:LinkButton ID="TbtSubmitRequest" runat="server" OnClick="TbtSubmitRequest_Click" CssClass="LinkButton">Submit Request</asp:LinkButton>

    <br />
    <asp:Label ID="LbSuccessMessage" runat="server"></asp:Label>

</asp:Content>


