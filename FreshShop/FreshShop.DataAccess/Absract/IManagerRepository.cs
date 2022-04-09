using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Absract
{
    public interface IManagerRepository:IRepository<Manager>
    {
        Manager Login(string userName,string password);
    }
}
