using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Challenge3
{
    class CustomerOrder
    {
        public OrderSummary Summary { get; set; }
        public List<LineItems> _ListOfLineItems { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
