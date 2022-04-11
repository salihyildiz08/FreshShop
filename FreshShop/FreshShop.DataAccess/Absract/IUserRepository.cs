using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.DataAccess.Absract
{
    public interface IUserRepository:IRepository<User>
    {
        User LogIn(string email,string password);
        User Get(Expression<Func<User, bool>> filter);
    }
}
