using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Symbolizes;
using Worlds.Model.Dimension.SpaceTime;

namespace Worlds.Model.Macroscopic.Animals
{
    /// <summary>
    /// 人类
    /// </summary>
    public class Human
    {
        #region 降临信息
        /// <summary>
        /// 降临坐标
        /// </summary>
        public PlanetSpaceTime CoordinateOfCome { get; private set; }





        #endregion

        #region 身份标识
        public YuanName Name { get; set; }



        #endregion

        #region 行为
        public void ComeOn(PlanetSpaceTime spaceTime)
        {

        }

        /// <summary>
        /// 降临
        /// </summary>
        public void ComeOn(Guid gid)
        {

        }

        /// <summary>
        /// 行走
        /// </summary>
        public void Walk()
        {

        }
        #endregion
    }
}
