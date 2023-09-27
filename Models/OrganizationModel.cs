using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FirstAPI_Project.Models
{
    public partial class OrganizationModel : DbContext
    {
        public OrganizationModel()
            : base("name=OrgModel")
        {
        }

        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
