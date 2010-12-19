using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;

namespace Model.Entities
{
    public partial class Opinion: IOpinion
    {
        #region IOpinion Members


        public Model.DataClasses.PersonShortData AuthorData
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
