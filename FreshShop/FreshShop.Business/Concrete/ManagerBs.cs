using FreshShop.Business.Absract;
using FreshShop.DataAccess.Absract;
using FreshShop.DataAccess.Concrete;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Concrete
{
    public class ManagerBs : IManagerBs
    {
        private readonly IManagerRepository _repo;
        public ManagerBs(IManagerRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Manager entity)
        {
            _repo.Delete(entity);
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Manager GetById(int id)
        {
            return GetById(id);
        }

        public int Insert(Manager entity)
        {
            return _repo.Insert(entity);
        }

        public Manager Login(string userName, string password)
        {
            return _repo.Login(userName,password);
        }

        public void Update(Manager entity)
        {
            _repo.Update(entity);
        }
    }
}
