﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;

#endregion
namespace ChinookSystem.DAL
{
    //This is an internal class for security reasons
    //Acces is restricted to within this class libray project
    //Inherits DbContext for Entity Framework,which reauires
    //  System.Data.Entity
    internal class ChinookContext : DbContext
    {
        // Pass the connection string name to the
        //  DbContext using :base()
        public ChinookContext() :base("ChinookDB")
        { }
    }
}
