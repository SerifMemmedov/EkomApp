using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SpecialProduct : BaseEntity
    {
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public int? Discount { get; set; }
    }
}
