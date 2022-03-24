using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductRecord:BaseEntity
    {

        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public int LanguageID { get; set; }
        public int ProductID{ get; set; }
        public virtual Product Product { get; set; }

    }
}
