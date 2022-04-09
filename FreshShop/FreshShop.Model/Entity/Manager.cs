using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.Model.Entity
{
    public class Manager:BaseEntity
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
