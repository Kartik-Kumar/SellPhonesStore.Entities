using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class OrdereredPhone
    {
        public long OrderedPhoneId { get; set; }
        public Phone OrderedPhone { get; set; }
        public float Quantity { get; set; }

    }
}
