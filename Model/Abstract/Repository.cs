﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Model.Abstract
{
    public abstract class Repository
    {
        protected DataContext context;
    }
}
