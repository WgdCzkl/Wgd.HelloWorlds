using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Shapes;
using Worlds.Model.Civilization.Symbolizes;

namespace Worlds.Model.Macroscopic.CivilizedCreation
{

    /// <summary>
    /// 文明造物
    /// </summary>
    public class YuanCivilizedCreation : Yuan
    {

        public YuanCivilizedCreation(YuanName name)
        {
            Name = name;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public YuanName Name { get; set; }

        /// <summary>
        /// 外形
        /// </summary>
        public YuanShape Shape { get; set; }
    }
}
