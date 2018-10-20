using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Customer : Person
    {
        private int _accountNumber;
        private CustomerStatusEnum _customerStatusEnum;

        public int accountNumber { get => _accountNumber; set => _accountNumber = value; }
        public CustomerStatusEnum customerStatusEnum { get => _customerStatusEnum; set => _customerStatusEnum = value; }

        public Customer()
        {

        }

        public Customer(int id, string name, int age, char gender, string email, CustomerStatusEnum customerStatusEnum) : base(id, name, age, gender, email)
        {
            _customerStatusEnum = customerStatusEnum;
        }

        public string Details()
        {
            return string.Format("Customer {0}\n{1}\n{2}\n{3}\n{4}\n{5}", base.id, base.name, base.age, base.gender, base.email, _customerStatusEnum);
        }
        
        public enum CustomerStatusEnum
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }
    }
}
