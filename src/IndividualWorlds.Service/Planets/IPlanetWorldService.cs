using PlanetWorlds.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.SpaceTime;

namespace IndividualWorlds.Service.Planets
{
    public interface IPlanetWorldService
    {
        PlanetWorld GetPlanetWorld(PlanetSpaceTime planetSpaceTime);
    }
}
