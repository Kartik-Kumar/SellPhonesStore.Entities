using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class CustomerOrder
    {
        public long OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public Customer customer { get; set; }
        public float OrderTotal { get; set; }
        public List<OrdereredPhone> OrderedPhones { get; set; } = new List<OrdereredPhone>();

    }
}
