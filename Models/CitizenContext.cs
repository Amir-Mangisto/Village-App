using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Village_App.Models
{
    public partial class CitizenContext : DbContext
    {
        public CitizenContext()
            : base("name=CitizenContext")
        {
        }

        public virtual DbSet<Citizen> Citizens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
