using SaleScale.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleManager
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Entities")
        {
            // Database.SetInitializer<ModelCase>(new DropCreateDatabaseIfModelChanges<ModelCase>());
        }
        public virtual DbSet<SaleSend> saleSends { get; set; }
        public virtual DbSet<SaleSendDetail> saleSendDetails { get; set; }

    }
}
