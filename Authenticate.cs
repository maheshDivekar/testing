using DomainLayer;
using RepositoryLayer.IRepository;
using ServiceLayer.AbstractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ConcreteServices
{
    public class Authenticate : IAuthenticate
    {
        private readonly IAuthenticateRepository _authenticateRepository;
        public Authenticate(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository=authenticateRepository;
        }
        public User AuthenticateUser(string userName, string password)
        {
          return  _authenticateRepository.AuthenticateUser(userName, password);   
        }

        public User GetUser(int UserID)
        {
          return  _authenticateRepository.GetUser(UserID);
        }
    }
}
