using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Models.Entities;

namespace Models.Abstract
{
    public abstract class Repository
    {
        protected VolonteersDataContext context;
        public Repository()
        {
            context = new VolonteersDataContext();
        }
    }
}
