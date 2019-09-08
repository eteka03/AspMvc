namespace prjQuestion1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LivresModel : DbContext
    {
        public LivresModel()
            : base("name=LivresModel")
        {
        }

        public virtual DbSet<livres> livres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
