using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Customer : Person
    {
        //customerStatus property with private backing field
        private string _customerStatus;
        public string CustomerStatus { get => _customerStatus; set => _customerStatus = value; }
        
        //Default constructor
        public Customer() { }

        //Constructor: Create a Customer object
        public Customer(string name, int age, string gender, string email, string customerStatus) : base(name, age, gender, email)
        {
            _customerStatus = CustomerStatus;
        }

        public string Details()
        {
            return string.Format("Customer {0}\n{1}\n{2}\n{3}\n{4}", base.Name, base.Age, base.Gender, base.Email, _customerStatus);
        }

        public enum CustomerStatusEnum
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }
    }
}
