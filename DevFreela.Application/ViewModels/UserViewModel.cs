using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
