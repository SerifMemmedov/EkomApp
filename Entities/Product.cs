using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product:BaseEntity
    {
       
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Rating  { get; set; }
        
        public int InStock { get; set; }
        public bool IsAvailability { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<ProductPicture> ProductPictures { get; set; }
        public virtual List<ProductRecord> ProductRecords { get; set; }
        public virtual List<ProductSpecification> ProductSpecifications { get; set; }



    }
}
