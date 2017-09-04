using PlanetWorlds.Model.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model;
using Worlds.Model.Civilization.Areas;

namespace PlanetWorlds.Model
{
    /// <summary>
    /// 星球世界
    /// </summary>
    public class PlanetWorld : YuanWorld
    {

        /// <summary>
        /// 大气层
        /// </summary>
        public Atmosphere Atmosphere { get; set; }

        /// <summary>
        /// 地壳
        /// </summary>
        public Crust Crust { get; set; }





        /// <summary>
        /// 区域
        /// </summary>
        public List<YuanArea> Areas { get; set; }
    }
}
