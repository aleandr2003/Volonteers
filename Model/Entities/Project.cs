﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;

namespace Models.Entities
{
    public partial class Project: IProject
    {
        #region IProject Members


        public string Descriptions
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        List<IVacancy> IProject.Vacancies
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
