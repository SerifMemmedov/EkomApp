using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductSpecification:BaseEntity
    {
        public int ProductID { get; set; }
        public int SpecificationID { get; set; } 
        public virtual Specification Specification { get; set; }   

    }
}
