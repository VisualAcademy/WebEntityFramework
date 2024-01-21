<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmTaskListsInsert.aspx.cs" Inherits="WebEntityFramework.FrmTaskListsInsert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

할일 : 
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
<br />
우선순위 : 
    <asp:DropDownList ID="lstPriority" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
    </asp:DropDownList>
<br />
    <asp:Button ID="btnAdd" runat="server" Text="할일 입력" onclick="btnAdd_Click" />

</asp:Content>
