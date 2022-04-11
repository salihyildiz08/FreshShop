using FreshShop.DataAccess.Absract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Concrete
{
    public class UserRepository : RepositoryBase<User, FreshShopDbContext>, IUserRepository
    {
        public User LogIn(string email, string password)
        {
            return Get(x => x.Email == email && x.Password == password);
        }
    }
}
