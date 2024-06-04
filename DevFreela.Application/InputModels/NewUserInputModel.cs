using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class NewUserInputModel : BaseEntity
    {
        public NewUserInputModel(string email)
        {
            Email = email;
        }

        public string Email { get; private set; }
    }
}
