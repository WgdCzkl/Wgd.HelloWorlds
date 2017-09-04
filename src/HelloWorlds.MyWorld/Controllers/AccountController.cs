using HelloWorlds.AccountService;
using HelloWorlds.MyWorld.Infrastructures;
using HelloWorlds.MyWorld.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Worlds.Model.Civilization.Passport;

namespace HelloWorlds.MyWorld.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: Account
        public ActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = _accountService.GetCosmicPassport(model.UserName, model.Password);
                if (loginResult.IsSuccess)
                {
                    SessionHelper.Add<CosmicPassport>(WebConstants.SESSION_KEY_COSMIC_PASSPORT, loginResult.Data);
                    return RedirectToAction("SceneSelection", "Home");
                }
                else
                {
                    ModelState.AddModelError("", loginResult.ResultMsg);
                }
            }

            // 如果执行到这里，发生某项失败，则重新显示窗体
            return View(model);
        }
    }
}