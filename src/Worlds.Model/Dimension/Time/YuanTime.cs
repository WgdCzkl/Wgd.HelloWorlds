using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worlds.Model.Dimension.Time
{
    public class YuanTime : YuanUnit
    {
        public YuanTime(decimal value) : base(value)
        {
        }

        /// <summary>
        /// 自定义 隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator YuanTime(Decimal value)
        {
            return new YuanTime(value);
        }
    }
}
