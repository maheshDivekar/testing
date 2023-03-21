using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AbstractServices
{
    public interface IAuthenticate
    {
        User AuthenticateUser(string userName, string password);

        User GetUser(int UserID);
    }
}
