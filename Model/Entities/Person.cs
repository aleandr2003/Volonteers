using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;

namespace Model.Entities
{
    public partial class Person: IPerson
    {
        #region IPerson Members


        public List<IOpinion> OpinionsToMe
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
