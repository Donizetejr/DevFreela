using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            var userViewModel = new UserViewModel(
                user.Id,
                user.FullName,
                user.Email
                );

            return userViewModel;
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public int Post(NewUserInputModel inputModel)
        {
            var user = new NewUserInputModel(inputModel.Email);

            return user.Id;
        }
    }
}
