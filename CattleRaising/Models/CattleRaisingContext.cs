using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CattleRaising.Models
{
    public class CattleRaisingContext: DbContext
    {
        public CattleRaisingContext(): base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public System.Data.Entity.DbSet<CattleRaising.Models.Municipality> Municipalities { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Exploitation> Exploitations { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<CattleRaising.Models.Farm> Farms { get; set; }
    }
}