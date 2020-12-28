using System;
using System.Data.Entity;
using System.Linq;

namespace SellPhonesStore.DataAccess
{
    public class SellPhoneDB : DbContext
    {
        
        public SellPhoneDB()
            : base("name=SellPhoneDB")
        {
        }


        
    }

   
}