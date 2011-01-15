using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;

namespace Models.Entities
{
    public partial class Message: IMessage
    {
        #region IMessage Members


        public IPerson Author
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

        public IPerson Recipient
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

        public Models.DataClasses.PersonShortData RecipientData
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
