using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Shapes;
using Worlds.Model.Civilization.Symbolizes;
using Worlds.Model.Macroscopic.CivilizedCreation;

namespace Worlds.Model.Civilization.Areas
{
    /// <summary>
    /// 地区
    /// </summary>
    public class YuanArea : YuanCivilizedCreation
    {
        public YuanArea(YuanName name) : base(name)
        {
        }


        /// <summary>
        /// 区域等级
        /// </summary>
        public int AreaGrade { get; set; }


        /// <summary>
        /// 子区域
        /// </summary>
        public List<YuanArea> SubAreas { get; set; }


        /// <summary>
        /// 道路
        /// </summary>
        public List<YuanRoad> Roads { get; set; }

        /// <summary>
        /// 建筑
        /// </summary>
        public List<YuanArchitecture> Architectures { get; set; }
    }
}
