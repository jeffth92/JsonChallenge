using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Challenge3
{
    class OrderPreface
    {
        public string OrderId { get; set; }
        public Customer Purchaser { get; set; }
        public ShippingAddress Destination { get; set; }

    }
}
