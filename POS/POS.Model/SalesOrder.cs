﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class SalesOrder
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PONumber { get; set; }
    }
}
