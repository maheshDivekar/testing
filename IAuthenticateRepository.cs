using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.IRepository
{
    public interface IAuthenticateRepository
    {
        User AuthenticateUser(string userName, string password);
        User GetUser(int UserID);
    }
}
