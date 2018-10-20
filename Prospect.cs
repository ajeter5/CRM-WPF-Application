using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Relationship_Management_Application
{
    class Prospect : Person//, IComparable
    {
        private CommunicationChannelEnum _communicationChannel;
        public CommunicationChannelEnum CommunicationChannel { get { return _communicationChannel; } set { _communicationChannel = value; } }

        public Prospect()
        {
        }

        public Prospect(int id, string name, int age, char gender, string email, CommunicationChannelEnum communicationChannel ) :base(id, name, age, gender, email)
        {
            _communicationChannel = communicationChannel;
        }

        public string Details()
        {
            return string.Format("Prospect {0}\n{1}\n{2}\n{3}\n{4}\n{5}", base.id, base.name, base.age, base.gender, base.email, _communicationChannel);
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
