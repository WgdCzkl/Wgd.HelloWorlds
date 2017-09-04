using IndividualWorlds.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.Space;
using Worlds.Model.Dimension.SpaceTime;

namespace IndividualWorlds.Service.Humans
{
    public interface IHumanWorldService
    {


        HumanWorld GetHumanWorld(string PassportNo, PlanetSpaceTime planetSpaceTime);

    }
}
