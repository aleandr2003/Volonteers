﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ProjectShortData>" %>
<%@ Import Namespace="Models.DataClasses" %>
<div>
    <img src="../../Content/Images/dummy_small.JPG">
    <div>
    <%= Html.ActionLink(Model.Name,
                        "Details",
                        "Project",
                        new { id = Model.Id},
                        null)%>
    </div>
    <div><%= String.Format("{0}", Model.StartDate.ToString("d MMMM yyyy"))%></div>
    
    <div><%= Html.Encode("Нужны " + String.Join(", ", Model.VacancyNames.ToArray()))%></div>
    <div><%= String.Format("Уже {0} участников", Model.VolonteersNumber)%>></div>
    <div><img src="../../Content/Images/dummy_small.JPG"> Организатор
        <%= Html.ActionLink(Model.AuthorName,
                            "Details",
                            "Person",
                            new {id = Model.AuthorId},
                            null)%>
    </div>
</div>

