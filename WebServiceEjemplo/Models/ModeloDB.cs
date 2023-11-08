using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebServiceEjemplo.Models
{
    public partial class ModeloDB : DbContext
    {
        public ModeloDB()
            : base("name=ModeloDB")
        {
        }
        public virtual DbSet<Producto> Productos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
