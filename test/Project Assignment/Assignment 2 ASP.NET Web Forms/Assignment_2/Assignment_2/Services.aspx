<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="Assignment_2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="text-center mb-4">Our Services</h2>

    <div class="row">

        <div class="col-md-4">
            <div class="card">
                <div class="card-body">
                    <h4>Website Design</h4>
                    <p>Modern and responsive websites.</p>
                </div>
            </div>
        </div>

        <div class="col-md-4">
            <div class="card">
                <div class="card-body">
                    <h4>Software Development</h4>
                    <p>Desktop and business applications.</p>
                </div>
            </div>
        </div>

        <div class="col-md-4">
            <div class="card">
                <div class="card-body">
                    <h4>Training</h4>
                    <p>Programming and internship guidance.</p>
                </div>
            </div>
        </div>

    </div>

</asp:Content>