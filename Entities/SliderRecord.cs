using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SliderRecord:BaseEntity
    {
        public int LanguageID { get; set; }
        public string? SubHeader { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? BackWord { get; set; }

        public int SliderID { get; set; }
        public virtual Slider Slider { get; set; }


    }
}
