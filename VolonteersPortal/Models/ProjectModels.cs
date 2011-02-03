using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VolonteersPortal.Models
{
    #region Models
    public class CreateProjectModel
    {
        [Required]
        [DisplayName("Название")]
        public string ProjectName { get; set; }

        [Required]
        [DisplayName("Цель")]
        public string Motto { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Начало")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("Окончание")]
        public DateTime EndDate { get; set; }
    }

    public class ProjectDetailsModel
    {
        [DisplayName("Название")]
        public string ProjectName { get; set; }

        [DisplayName("Цель")]
        public string Motto { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Начало")]
        public DateTime StartDate { get; set; }

        [DisplayName("Окончание")]
        public DateTime EndDate { get; set; }
    }
    #endregion
}
