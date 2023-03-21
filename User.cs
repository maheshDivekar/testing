using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
    }
}
