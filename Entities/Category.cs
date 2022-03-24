using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category : BaseEntity
    {
        public int ParentCategoryID { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public bool IsFeatured { get; set; }
        public string SantiziedName { get; set; }
        public int DisPlaySeqNo { get; set; }
        public int PictureID { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<CategoryRecord> CategoryRecords { get; set; }





    }
}
