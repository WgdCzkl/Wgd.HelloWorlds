using HelloWorlds.MyWorld.Infrastructures;
using IndividualWorlds.Model;
using IndividualWorlds.Service.Humans;
using IndividualWorlds.Service.Planets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Worlds.Model;
using Worlds.Model.Dimension.Space;
using Worlds.Model.Dimension.SpaceTime;

namespace HelloWorlds.MyWorld.Controllers
{
    public class HomeController : BaseController
    {

        private readonly IHumanWorldService _humanWorldService;
        private readonly IPlanetWorldService _planetWorldService;
        public HomeController(
            IHumanWorldService humanWorldService
            , IPlanetWorldService planetWorldService
            )
        {
            _humanWorldService = humanWorldService;
            _planetWorldService = planetWorldService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SceneSelection()
        {

            return View();
        }

        public ActionResult GoWorld()
        {

            PlanetSpaceTime time = null;

            var humanWorld = _humanWorldService.GetHumanWorld(CurrPassport.PassportNo, time);

            SessionHelper.Add<HumanWorld>(WebConstants.SESSION_KEY_WORLD, humanWorld);

            return RedirectToAction("ComeToWorld", "Worlds");
        }
    }
}