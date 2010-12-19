using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;

namespace Model.Entities
{
    public partial class Comment: IComment
    {
        #region IComment Members


        public int PersonId
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
