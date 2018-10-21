using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Person
    {
        //Create name, age, gender, and email properties with private backing variables
        private string _name;
        private int _age;
        private string _gender;
        private string _email;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        
        public Person() { }
        
        //Constructor: Create a Person object
        public Person(string name, int age, string gender, string email)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _email = email;
        }
    }
}
