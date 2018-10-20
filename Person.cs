using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Person
    {
        private int _id;
        private string _name;
        private int _age;
        private char _gender;
        private string _email;

        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public int age { get => _age; set => _age = value; }
        public char gender { get => _gender; set => _gender = value; }
        public string email { get => _email; set => _email = value; }
        
        public Person()
        {
        }

        public Person(int id, string name, int age, char gender, string email)
        {
            _id = id;
            _name = name;
            _age = age;
            _gender = gender;
            _email = email;
        }
    }
}
