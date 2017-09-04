using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worlds.Model
{
    public class YuanUnit : Yuan
    {
        public YuanUnit(Decimal value)
        {
            Value = value;
        }

        #region 属性
        public Decimal Value { get; set; }
        #endregion

        #region 运算符重写
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(YuanUnit y1, YuanUnit y2)
        {
            return y1.Value == y2.Value;
        }

        public static bool operator !=(YuanUnit y1, YuanUnit y2)
        {
            return y1.Value != y2.Value;
        }


        public static decimal operator /(YuanUnit y1, YuanUnit y2)
        {
            return y1.Value / y2.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        #endregion

        #region 隐式转换
        /// <summary>
        /// 自定义 隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator YuanUnit(Decimal value)
        {
            return new YuanUnit(value);
        }
        #endregion

    }
}
