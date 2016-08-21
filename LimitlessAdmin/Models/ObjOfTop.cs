﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LimitlessAdmin.Models
{
    public class ObjOfTop
    {
        public int ID { get; set; }

        public virtual Topic Topic { get; set;}
        public virtual Objective Objective { get; set; }
        public virtual Organization Organization { get; set; }

    }
}