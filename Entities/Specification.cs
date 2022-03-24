﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Specification:BaseEntity
    {
        public string? Icon { get; set; }
        public virtual List<SpecificationRecord> SpecificationRecords { get; set; }


    }
} 
