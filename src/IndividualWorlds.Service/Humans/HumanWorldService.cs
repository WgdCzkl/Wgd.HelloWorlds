using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualWorlds.Model;
using Worlds.Model.Dimension.Space;
using Worlds.Model.Dimension.SpaceTime;
using IndividualWorlds.Service.Planets;

namespace IndividualWorlds.Service.Humans
{
    public class HumanWorldService : IHumanWorldService
    {
        private readonly IPlanetWorldService _planetWorldService;
        public HumanWorldService(IPlanetWorldService planetWorldService)
        {
            _planetWorldService = planetWorldService;
        }

        public HumanWorld GetHumanWorld(string PassportNo, PlanetSpaceTime planetSpaceTime)
        {
            HumanWorld world = new HumanWorld();

            world.OutsideWorld = _planetWorldService.GetPlanetWorld(planetSpaceTime);


            return world;
        }
    }
}
