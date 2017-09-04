using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Symbolizes;
using Worlds.Model.Macroscopic.CivilizedCreation;

namespace Worlds.Model.Civilization.DailyLife
{
    /// <summary>
    /// 电梯
    /// </summary>
    public class YuanElevator : YuanCivilizedCreation
    {
        public YuanElevator(YuanName name) : base(name)
        {
        }


        /// <summary>
        /// 电梯厢
        /// </summary>
        public ElevatorCar Car { get; set; }
    }


    /// <summary>
    /// 轿厢(电梯厢)
    /// </summary>
    public class ElevatorCar
    {

        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }
    }
}
