﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<VolonteersPortal.Models.ProjectDetailsModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	<%= Model.ProjectName %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%= Model.ProjectName %></h2>
    
    <div class="display-label">
        <%= Html.LabelFor(m => m.Motto) %>
    </div>
    <div class="display-field">
        <%= Model.Motto %>
    </div>
    <div class="display-label">
        <%= Html.LabelFor(m => m.StartDate) %>
    </div>
    <div class="display-field">
        <%= Model.StartDate.ToString("d MMMM yyyy - HH:mm")%>
    </div>
    <div class="display-label">
        <%= Html.LabelFor(m => m.EndDate) %>
    </div>
    <div class="display-field">
        <%= Model.EndDate.ToString("d MMMM yyyy - HH:mm")%>
    </div>
    <div class="display-label">
        <%= Html.LabelFor(m => m.Description) %>
    </div>
    <div class="display-field">
        <%= Model.Description%>
    </div>

</asp:Content>
