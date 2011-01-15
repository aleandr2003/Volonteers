<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<VolonteersPortal.Models.CreateProjectModel>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Новый проект
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

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
            <%= Html.LabelFor(m => m.Day) %>
        </div>
        <div class="editor-field">
            <%= Html.DropDownListFor(m => m.Day,
                new List<SelectListItem> {
                    new SelectListItem{ Text = "1", Value = "1", Selected=true},
                    new SelectListItem{ Text = "2", Value = "2"},
                    new SelectListItem{ Text = "3", Value = "3"},
                    new SelectListItem{ Text = "4", Value = "4"},
                    new SelectListItem{ Text = "5", Value = "5"},
                    new SelectListItem{ Text = "6", Value = "6"},
                    new SelectListItem{ Text = "7", Value = "7"},
                    new SelectListItem{ Text = "8", Value = "8"},
                    new SelectListItem{ Text = "9", Value = "9"},
                    new SelectListItem{ Text = "10", Value = "10"},
                    new SelectListItem{ Text = "11", Value = "11"},
                    new SelectListItem{ Text = "12", Value = "12"},
                    new SelectListItem{ Text = "13", Value = "13"},
                    new SelectListItem{ Text = "14", Value = "14"},
                    new SelectListItem{ Text = "15", Value = "15"},
                    new SelectListItem{ Text = "16", Value = "16"},
                    new SelectListItem{ Text = "17", Value = "17"},
                    new SelectListItem{ Text = "18", Value = "18"},
                    new SelectListItem{ Text = "19", Value = "19"},
                    new SelectListItem{ Text = "20", Value = "20"},
                    new SelectListItem{ Text = "21", Value = "21"},
                    new SelectListItem{ Text = "22", Value = "22"},
                    new SelectListItem{ Text = "23", Value = "23"},
                    new SelectListItem{ Text = "24", Value = "24"},
                    new SelectListItem{ Text = "25", Value = "25"},
                    new SelectListItem{ Text = "26", Value = "26"},
                    new SelectListItem{ Text = "27", Value = "27"},
                    new SelectListItem{ Text = "28", Value = "28"},
                    new SelectListItem{ Text = "29", Value = "29"},
                    new SelectListItem{ Text = "30", Value = "30"},
                    new SelectListItem{ Text = "31", Value = "31"}
            } )%>
            <%= Html.ValidationMessageFor(m => m.Day)%>
        </div>
        <div class="editor-label">
            <%= Html.LabelFor(m => m.Day) %>
        </div>
        <div class="editor-field">
            <%= Html.DropDownListFor(m => m.Month,
                new List<SelectListItem> {
                    new SelectListItem{ Text = "Январь", Value = "1", Selected=true},
                    new SelectListItem{ Text = "Февраль", Value = "2"},
                    new SelectListItem{ Text = "Март", Value = "3"},
                    new SelectListItem{ Text = "Апрель", Value = "4"},
                    new SelectListItem{ Text = "Май", Value = "5"},
                    new SelectListItem{ Text = "Июнь", Value = "6"},
                    new SelectListItem{ Text = "Июль", Value = "7"},
                    new SelectListItem{ Text = "Август", Value = "8"},
                    new SelectListItem{ Text = "Сентябрь", Value = "9"},
                    new SelectListItem{ Text = "Октябрь", Value = "10"},
                    new SelectListItem{ Text = "Ноябрь", Value = "11"},
                    new SelectListItem{ Text = "Декабрь", Value = "12"}
            } )%>
            <%= Html.ValidationMessageFor(m => m.Day)%>
        </div>
        
    <% } %>

</asp:Content>
