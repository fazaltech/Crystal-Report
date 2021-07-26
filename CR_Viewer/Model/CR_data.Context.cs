using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Viewer.Model
{
    public partial class cr_dataEntities : DbContext
    {
        

         public virtual DbSet<bio_info> bio_info { get; set; }




        public cr_dataEntities()
                 : base("cr_dataEntities")
        {
            Database.CreateIfNotExists();
        }

    }
}
