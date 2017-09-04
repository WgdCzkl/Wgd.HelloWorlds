using PlanetWorlds.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model;
using Worlds.Model.Macroscopic.Animals;

namespace IndividualWorlds.Model
{
    /// <summary>
    /// 人类世界
    /// </summary>
    public class HumanWorld : YuanWorld
    {

        /// <summary>
        /// 载体
        /// </summary>
        public new Human Carrier { get; set; }


        /// <summary>
        /// 精神
        /// </summary>
        public MentalWorld Mental { get; set; }

        /// <summary>
        /// 触觉
        /// </summary>
        public TouchWorld Touch { get; set; }

        /// <summary>
        /// 视觉
        /// </summary>
        public VisualWorld Visual { get; set; }




        /// <summary>
        /// 外部世界
        /// </summary>
        public new PlanetWorld OutsideWorld { get; set; }



    }
}
