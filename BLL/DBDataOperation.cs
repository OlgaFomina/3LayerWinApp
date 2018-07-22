using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DbDataOperation
    {
        private PhonesDB db;
        public DbDataOperation()
        {
            db = new PhonesDB();
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            return db.Phones;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public Phone GetPhone(int phoneId)
        {
            return db.Phones.Find(phoneId); 
        }

        public bool CreateOrder (Order order)
        {
            db.Orders.Add(order);
            if (db.SaveChanges()>0) return true;
            return false;
        }
    }
}
