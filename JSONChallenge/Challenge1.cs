using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Challenge1
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EventTitle { get; set; }
        public int EventCapacity { get; set; }
        public decimal PriceOfAdmission { get; set; }

        public Challenge1()
        {

        }

        public Challenge1(
            DateTime startDate,
            DateTime endDate,
            string eventTitle,
            int eventCapacity,
            decimal priceOfAdmission)
        {
            StartDate = startDate;
            EndDate = endDate;
            EventTitle = eventTitle;
            EventCapacity = eventCapacity;
            PriceOfAdmission = priceOfAdmission;
        }
    }
}
