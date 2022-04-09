using FreshShop.DataAccess.Absract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Concrete
{
    public class ManagerRepository : RepositoryBase<Manager, FreshShopDbContext>, IManagerRepository
    {
        public Manager Login(string userName, string password)
        {
            return Get(x => x.UserName == userName && x.Password == password);
        }
    }
}
