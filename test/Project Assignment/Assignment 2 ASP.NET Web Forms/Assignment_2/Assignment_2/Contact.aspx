<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Assignment_2.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="text-center mb-4">Contact Us</h2>

    <div class="card p-4">

        <div class="mb-3">
            <label>Name</label>

            <asp:TextBox
                ID="txtName"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Contact</label>

            <asp:TextBox
                ID="txtContact"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Email</label>

            <asp:TextBox
                ID="txtEmail"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Service Required</label>

            <asp:DropDownList
                ID="ddlService"
                runat="server"
                CssClass="form-control">

                <asp:ListItem>Select Service</asp:ListItem>
                <asp:ListItem>Website Design</asp:ListItem>
                <asp:ListItem>Software Development</asp:ListItem>
                <asp:ListItem>Training</asp:ListItem>

            </asp:DropDownList>
        </div>

        <div class="mb-3">
            <label>Message</label>

            <asp:TextBox
                ID="txtMessage"
                runat="server"
                TextMode="MultiLine"
                Rows="4"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <asp:Button
            ID="btnSubmit"
            runat="server"
            Text="Submit"
            CssClass="btn btn-success"
            OnClick="btnSubmit_Click" />

        <br />

        <asp:Label
    ID="lblMsg"
    runat="server"
    ForeColor="Green" />

    </div>

</asp:Content>