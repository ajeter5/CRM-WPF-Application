using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Prospect : Person//, IComparable
    {
        //CommunicationChannel property with private backing field
        private string _communicationChannel;
        public string CommunicationChannel { get { return _communicationChannel; } set { _communicationChannel = value; } }
        
        //Default constructor
        public Prospect() { }

        //Constructor: Create a Prospect object
        public Prospect(string name, int age, string gender, string email, string communicationChannel ) :base(name, age, gender, email)
        {
            _communicationChannel = communicationChannel;
        }

        public string Details()
        {
            return string.Format("Prospect {0}\n{1}\n{2}\n{3}\n{4}", base.Name, base.Age, base.Gender, base.Email, _communicationChannel);
        }
                
        public enum CommunicationChannelEnum
        {
            InternetSearchEngine = 1,
            EmailFlyer = 2,
            Mail = 3,
            Friend = 4,
            Other = 5
        }
    }
}
