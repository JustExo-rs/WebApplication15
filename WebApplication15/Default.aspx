<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication15._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="341px" Width="425px">
        <Columns>
            <asp:BoundField DataField="Naziv" HeaderText="Naziv" />
            <asp:BoundField DataField="Vrsta" HeaderText="Vrsta" />
            <asp:BoundField DataField="Dobavljac" HeaderText="Dobavljac" />
            <asp:ImageField DataImageUrlField="imageURL" HeaderText="Slika">
            </asp:ImageField>
        </Columns>
    </asp:GridView>

    

</asp:Content>
