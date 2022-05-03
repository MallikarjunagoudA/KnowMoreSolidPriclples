using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMoreSRP
{
    interface ILogin 
    {
        public void signup(string username, string password, string email, string phone);
        public void Login(string username, string password);
    }

    interface ErrorHandle
    {
        public void ErrorHandle(string err);
    }

    interface SendMail
    {
        public void SendMail(string subject, string body);
    }


}
