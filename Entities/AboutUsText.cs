using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AboutUsText:BaseEntity
    {

        public string? IconUrl { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
