using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Encapculation
{
    public class Customer
    {
        public int Id { get; set; }
        private String _firstName;
        public String FirstName {
            get {
                return FirstName;
            } set
            { _firstName = value;
            }
        }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
,    }
}
