using FreshShop.Business.Absract;
using FreshShop.Model.Entity;
using FreshShop.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MVCWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ManagerController : Controller
    {
        private readonly IManagerBs _managerBs;
        public ManagerController(IManagerBs managerBs)
        {
            _managerBs = managerBs;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(ManagerLogInVm vm)
        {
            Manager manager= _managerBs.Login(vm.UserName,vm.Password);
            if(manager!=null)
                return Json(new {IsOk=true });

            return Json(new { IsOk = false,Message="Kullanıcı Bulunamadı." });
        }

    }
}
