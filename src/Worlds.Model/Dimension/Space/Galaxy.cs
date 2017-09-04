using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worlds.Model.Dimension.Space
{
    /// <summary>
    /// 星系
    /// </summary>
    public class Galaxy : Yuan
    {
        public Galaxy(Planet centerPlanet, List<Planet> surroundPlanets)
        {
            CenterPlanet = centerPlanet;
            CenterPlanet.Galaxy = this;
            SurroundPlanets = surroundPlanets;
        }


        /// <summary>
        /// 父星系
        /// </summary>
        public Galaxy ParentGalaxy { get; set; }


        List<Galaxy> _childrensGalaxy = null;
        /// <summary>
        /// 子星系
        /// </summary>
        public List<Galaxy> ChildrensGalaxy
        {
            get
            {
                if (_childrensGalaxy == null)
                {
                    _childrensGalaxy = new List<Galaxy>();
                }
                return _childrensGalaxy;
            }
        }

        /// <summary>
        /// 中心星球
        /// </summary>
        public Planet CenterPlanet { get; set; }

        /// <summary>
        /// 星球
        /// </summary>
        public List<Planet> SurroundPlanets { get; set; }


        #region 属性

        #endregion

        #region 动作
        /// <summary>
        /// 添加子星系
        /// </summary>
        /// <param name="galaxy"></param>
        /// <returns></returns>
        public Boolean AddChildrensGalaxy(Galaxy galaxy)
        {
            ChildrensGalaxy.Add(galaxy);
            galaxy.CenterPlanet.RevolutionPlanet = CenterPlanet;
            return true;
        }
        #endregion

    }
}
