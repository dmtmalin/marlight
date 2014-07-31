using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlight
{
    public class cObjectIpPort
    {
        public cObjectIpPort() { }

        public cObjectIpPort(string ip, int port) 
        {
            _Ip = ip;
            _Port = port;
        }

        private string _Ip;
        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }

        private int _Port;
        public int Port
        {
            get { return _Port; }
            set { _Port = value; }
        }
    }
}
