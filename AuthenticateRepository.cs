using DomainLayer;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        private List<User> appUsers = new List<User>
              {
                 new User { AccountId = 123,UserId=1, UserLogin="MAS", UserName= "Vaibhav Bhapkar",FullName="Vaibhav Bhapkar" },
                 new User { AccountId = 123,UserId=1, UserLogin="MASD", UserName= "Vaibhav Bhapkar",FullName="Vaibhav Bhapkar"}
              };
        public User AuthenticateUser(string userName, string password)
        {
            User User = appUsers.FirstOrDefault(x => x.UserLogin == userName);
            return User;
        }

        public User GetUser(int UserID)
        {
            User User = appUsers.FirstOrDefault(x => x.UserId == UserID);
            return User;
        }
    }
}
