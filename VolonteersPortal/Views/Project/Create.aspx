<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<VolonteersPortal.Models.CreateProjectModel>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Новый проект
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="IncludesContent" runat="server">
    <link href="../../Content/jquery.ui.all.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../Scripts/jquery-1.4.1.js"></script>
<script type="text/javascript" src="../../Scripts/jquery.ui.core.js"></script>
<script type="text/javascript" src="../../Scripts/jquery.ui.datepicker.js"></script>
<script type="text/javascript" src="../../Scripts/i18n/jquery.ui.datepicker-ru.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function() {
        $.datepicker.setDefaults($.datepicker.regional[""]);
        $(".datepicker").datepicker($.datepicker.regional["ru"]);
    });
</script>
    <h2>Новый проект</h2>
    <% using (Html.BeginForm()) { %>
        <div class="editor-label">
            <%= Html.LabelFor(m => m.ProjectName) %>
        </div>
        <div class="editor-field">
            <%= Html.TextBoxFor(m => m.ProjectName) %>
            <%= Html.ValidationMessageFor(m => m.ProjectName)%>
        </div>
        
        <div class="editor-label">
            <%= Html.LabelFor(m => m.Motto) %>
        </div>
        <div class="editor-field">
            <%= Html.TextBoxFor(m => m.Motto)%>
            <%= Html.ValidationMessageFor(m => m.Motto)%>
        </div>
        
        <div class="editor-label">
            <%= Html.LabelFor(m => m.Description) %>
        </div>
        <div class="editor-field">
            <%= Html.TextBoxFor(m => m.Description)%>
            <%= Html.ValidationMessageFor(m => m.Description)%>
        </div>
        
        <div class="editor-label">
            <%= Html.LabelFor(m => m.StartDate) %>
        </div>
        <div class="editor-label">
            <%= Html.TextBoxFor(m => m.StartDate, new  { @class="datepicker" })%>
        </div>
        <div class="editor-field">
            <%= Html.ValidationMessageFor(m => m.StartDate)%>
        </div>
        <div class="editor-label">
            <%= Html.LabelFor(m => m.EndDate) %>
        </div>
        <div class="editor-label">
            <%= Html.TextBoxFor(m => m.EndDate, new { @class = "datepicker" })%>
        </div>
        <div class="editor-field">
            <%= Html.ValidationMessageFor(m => m.EndDate)%>
        </div>
        <div class="editor-field">
        
            <p>
                <input type="submit" value="Создать" />
            </p>
        </div>
        
    <% } %>

</asp:Content>
