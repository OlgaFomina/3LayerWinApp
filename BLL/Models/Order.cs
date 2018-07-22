using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public decimal? Total { get; set; }

        public string Customer { get; set; }

        public DateTime Date { get; set; }

        public List<int> OrderedPhonesIds { get; set; }

    }
}
