﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string PinCode { get; set; }
        public long MobileNo { get; set; }
        public List<CustomerOrder> Ordes { get; set; }

    }
}
