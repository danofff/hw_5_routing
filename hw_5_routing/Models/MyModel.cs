namespace hw_5_routing.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<TrackServiceHistory> TrackServiceHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
