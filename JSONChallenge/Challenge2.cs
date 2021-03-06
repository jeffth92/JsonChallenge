using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Challenge2
    {
        public int BadgeId { get; set; }
        public List<string> ListOfDoors  { get; set; }
        public bool HasSecurityClearance { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }

        public Challenge2()
        {

        }

        public Challenge2(
            int badgeId,
            List<string> listOfDoors,
            bool hasSecurityClearance,
            string employeeId,
            DateTime createdOn)
        {
            BadgeId = badgeId;
            ListOfDoors = listOfDoors;
            HasSecurityClearance = hasSecurityClearance;
            EmployeeId = employeeId;
            CreatedOn = createdOn;
        }
    }
}
