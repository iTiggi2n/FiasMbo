namespace FIAS.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=Model")
        {
        }

        public virtual DbSet<Regions> Regions { get; set; }
    }
}
