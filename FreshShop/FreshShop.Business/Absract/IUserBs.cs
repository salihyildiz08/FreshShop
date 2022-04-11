using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Absract
{
    public interface IUserBs
    {
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        User Get(Expression<Func<User, bool>> filter);
        User GetById(int id);
        int Insert(User entity);
        void Update(User entity);
        void Delete(User entity);
        User LogIn(string email, string password);
    }
}
