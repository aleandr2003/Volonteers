using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;

namespace Models.Entities
{
    public partial class Opinion: IOpinion
    {
        #region IOpinion Members


        public Models.DataClasses.PersonShortData AuthorData
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

        public bool IsSupported(int PersonId)
        {
            throw new NotImplementedException();
        }

        public void Support(int PersonId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
