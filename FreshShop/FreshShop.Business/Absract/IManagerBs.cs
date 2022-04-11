using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreshShop.Business.Absract
{
    public interface IManagerBs
    {
        List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null);
        Manager Get(Expression<Func<Manager, bool>> filter);
        Manager GetById(int id);
        int Insert(Manager entity);
        void Update(Manager entity);
        void Delete(Manager entity);
        Manager Login(string userName, string password);
    }
}
