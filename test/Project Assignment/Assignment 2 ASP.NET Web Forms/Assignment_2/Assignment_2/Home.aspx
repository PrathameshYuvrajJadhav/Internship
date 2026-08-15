<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment_2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">

        <h1>Welcome to Tech Solutions</h1>

        <p>
            We provide quality IT services and training programs
            for students and businesses.
        </p>

        <asp:Button ID="Button1"
            runat="server"
            Text="Know More"
            CssClass="btn btn-primary" />

    </div>

</asp:Content>