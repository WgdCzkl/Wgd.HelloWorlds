using HelloWorlds.MyWorld.Controllers.Base;
using HelloWorlds.MyWorld.Models.Worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorlds.MyWorld.Controllers
{
    public class WorldsController : BaseWorldController
    {
        //降临到世界
        public ActionResult ComeToWorld()
        {
            ComeToWorldViewModel vm = new ComeToWorldViewModel();

            vm.Areas = CurrPlanetWorld.Areas;
            return View(vm);
        }

        public ActionResult ComeToArea()
        {
            return View();
        }
    }
}