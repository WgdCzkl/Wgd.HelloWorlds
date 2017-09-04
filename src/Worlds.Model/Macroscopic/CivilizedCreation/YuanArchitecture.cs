using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.DailyLife;
using Worlds.Model.Civilization.Shapes;
using Worlds.Model.Civilization.Symbolizes;

namespace Worlds.Model.Macroscopic.CivilizedCreation
{
    /// <summary>
    /// 建筑
    /// </summary>
    public class YuanArchitecture : YuanCivilizedCreation
    {
        public YuanArchitecture(YuanName name) : base(name)
        {

        }


        /// <summary>
        /// 子楼层
        /// </summary>
        public List<YuanStorey> SubStoreys { get; set; }


        /// <summary>
        /// 电梯
        /// </summary>
        public List<YuanElevator> Elevators { get; set; }

        /// <summary>
        /// 楼梯
        /// </summary>
        public List<YuanStaircase> Staircases { get; set; }

    }


    /// <summary>
    /// 楼层
    /// </summary>
    public class YuanStorey : YuanCivilizedCreation
    {
        public YuanStorey(YuanName name) : base(name)
        {
        }

        /// <summary>
        /// 内部建筑
        /// </summary>
        public List<YuanCivilizedCreation> SubArchitecture { get; set; }
    }
}
