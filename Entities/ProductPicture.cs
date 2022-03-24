﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductPicture:BaseEntity
    {

        public int PictureID { get; set; }
        public int ProductID { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
