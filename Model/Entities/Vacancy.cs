using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;

namespace Models.Entities
{
    public partial class Vacancy: IVacancy
    {
        #region IVacancy Members


        public bool ApprovalRequired
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

        public List<IPerson> AppliedPersons
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

        public List<IPerson> ApprovedPersons
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
