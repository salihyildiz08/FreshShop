using FreshShop.Business.Absract;
using FreshShop.DataAccess.Absract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Concrete
{
    public class UserBs : IUserBs
    {
        private readonly IUserRepository _repo;
        public UserBs(IUserRepository repo)
        {
            _repo = repo;
        }
        public void Delete(User entity)
        {
            _repo.Delete(entity);
        }


        public User Get(Expression<Func<User, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public User GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(User entity)
        {
            return _repo.Insert(entity);
        }

        public User LogIn(string email, string password)
        {
            return _repo.LogIn(email, password);
        }

        public void Update(User entity)
        {
            _repo.Update(entity);
        }
    }
}
