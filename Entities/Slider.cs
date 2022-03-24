using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Slider:BaseEntity
    {
   
        public string? PhotoUrl { get; set; }
        public virtual List<SliderRecord> SliderRecords { get; set; }
    }
}
