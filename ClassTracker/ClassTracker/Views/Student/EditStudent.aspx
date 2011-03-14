<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ClassTracker.Models.Student>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditStudent
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit Student</h2>

    <form action="/Student/EditStudent" method="post" >
    First Name: <br />
    <%: Html.TextBoxFor(x => x.FirstName) %>
    <br />
    Last Name: <br />
    <%: Html.TextBoxFor(x => x.LastName) %>
    <br />
    Phone Number: <br />
    <%: Html.TextBoxFor(x => x.Phone) %>
    <br />
    NetworkId: <br />
    <%: Html.TextBoxFor(x => x.NetworkID) %>
    <br />
    Email: <br />
    <%: Html.TextBoxFor(x => x.Email) %>
    <br />
    <input type="submit" value="Submit" />

    </form>

</asp:Content>
