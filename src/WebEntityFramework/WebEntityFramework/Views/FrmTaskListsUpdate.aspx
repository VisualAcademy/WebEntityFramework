<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmTaskListsUpdate.aspx.cs" Inherits="WebEntityFramework.FrmTaskListsUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="ctlTaskLists" runat="server">
    </asp:GridView>

번호 :
    <asp:TextBox ID="txtListId" runat="server"></asp:TextBox>
<br />
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
완료 : 
    <asp:CheckBox ID="chkIsComplete" runat="server" />
<br />
    <asp:Button ID="btnModify" runat="server" Text="할일 수정" 
        onclick="btnModify_Click" />


</asp:Content>
