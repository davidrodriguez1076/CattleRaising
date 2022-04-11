using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CattleRaising.Context
{
    public class StoreCattleRaising: DbContext
    {        
        //public System.Data.Entity.DbSet<CattleRaising.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Municipality> Municipalities { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Exploitation> Exploitations { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Country> Countries { get; set; }
    }
}