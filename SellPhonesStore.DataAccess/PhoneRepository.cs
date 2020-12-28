using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        public List<CustomerOrder> GetAllCustomerOrders()
        {
            throw new NotImplementedException();
        }

        public List<CustomerOrder> GetCustomerOrders(long customerID)
        {
            throw new NotImplementedException();
        }

        public long SaveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public long SaveOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public long SaveOrderedPhone(OrdereredPhone orderPhone, long orderId)
        {
            throw new NotImplementedException();
        }

        public long SavePhone(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
