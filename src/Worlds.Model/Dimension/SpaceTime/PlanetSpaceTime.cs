using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.Space;
using Worlds.Model.Dimension.Time;

namespace Worlds.Model.Dimension.SpaceTime
{
    /// <summary>
    /// 星球时空
    /// </summary>
    public class PlanetSpaceTime
    {

        public Guid PlanetNo { get; set; }

        /// <summary>
        /// 星球时间
        /// </summary>
        public PlanetTime PlanetTime { get; set; }

        /// <summary>
        /// 星球空间
        /// </summary>
        public PlanetSpace PlanetSpace { get; set; }



     

    }
}
