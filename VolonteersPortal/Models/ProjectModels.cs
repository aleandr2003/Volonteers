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
        [DisplayName("День")]
        public int Day { get; set; }

        [Required]
        [DisplayName("Месяц")]
        public int Month { get; set; }

        [Required]
        [DisplayName("Год")]
        public int Year { get; set; }
    }

    public class ProjectDetailsModel
    {
        [DisplayName("Название")]
        public string ProjectName { get; set; }

        [DisplayName("Цель")]
        public string Motto { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
    #endregion
}
