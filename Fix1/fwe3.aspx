<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="fwe3.aspx.vb" Inherits="Fix1.fwe3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    收件人<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    副本<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    內容<asp:TextBox ID="TextBox3" runat="server" Height="316px" Width="372px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="送出" />
    <br />
</asp:Content>
