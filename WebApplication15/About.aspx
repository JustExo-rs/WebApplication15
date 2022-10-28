<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication15.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" Width="196px">Naziv cveta : </asp:TextBox><br />
    <asp:TextBox ID="TextBox2" runat="server" Width="193px">Vrsta cveta :</asp:TextBox><br />
    <asp:TextBox ID="TextBox3" runat="server" Width="190px">Dobavljac :</asp:TextBox><br /><br />
    <asp:TextBox ID="TextBox4" runat="server" Width="186px">Slika cveta : </asp:TextBox>
    <asp:FileUpload ID="FileUpload1" runat="server" Width="93px" /><br />
    
    <asp:Button ID="Button1" runat="server" Text="Dodaj novi cvet" OnClick="Button1_Click" />
    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
</asp:Content>
