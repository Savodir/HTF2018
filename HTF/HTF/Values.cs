﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Values
    {
        public String name { get; set; }
        public String data { get; set; }
        public Values(String name, String data)
        {
            this.name = name;
            this.data = data;
        }
    }
}
