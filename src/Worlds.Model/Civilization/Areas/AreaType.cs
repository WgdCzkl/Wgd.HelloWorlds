using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Symbolizes;

namespace Worlds.Model.Civilization.Areas
{
    /// <summary>
    /// 地区类型
    /// </summary>
    public class AreaType
    {

        public AreaType(string typeName)
        {
            Name = typeName;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public YuanName Name { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public int AreaGrade { get; set; }
    }
}
