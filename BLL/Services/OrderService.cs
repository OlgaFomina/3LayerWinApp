using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService
    {

        private DbDataOperation db;
        public OrderService()
        {
            db = new DbDataOperation();
        }

        public bool MakeOrder(OrderModel orderDto)
        {
            List<Phone> orderedphones = new List<Phone>();
            decimal sum = 0;
            foreach (int phoneId in orderDto.OrderedPhonesIds)
            {
                Phone phone = db.GetPhone(phoneId);
                // валидация
                if (phone == null)
                    throw new Exception("Телефон не найден");
                sum += phone.Cost;
                orderedphones.Add(phone);
            }
            // применяем скидку
            sum = new Discount(0.1m).GetDiscountedPrice(sum);

            Order order = new Order
            {
                Date = DateTime.Now,
                Address = orderDto.Address,
                Total = sum,
                PhoneNumber = orderDto.PhoneNumber,
                Customer =orderDto.Customer,
                Phones = orderedphones
            };
            return db.CreateOrder(order);
       
        }

 


    }
}
