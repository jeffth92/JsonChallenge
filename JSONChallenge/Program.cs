using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Jeff";
            person.LastName = "Hackett";
            person.DOB = new DateTime(1992, 2, 21);

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
