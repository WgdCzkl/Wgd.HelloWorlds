using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worlds.Model
{
    public class Yuan
    {
        /// <summary>
        /// ID 唯一标识
        /// </summary>
        public Guid ID { get; set; }


        public string Key
        {
            get
            {
                return ID.ToString();
            }
        }

        /// <summary>
        /// 可见等级
        /// </summary>
        public Decimal VisibleGrade { get; set; }

        /// <summary>
        /// 可见等级范围
        /// </summary>
        public int VisibleGradeRange { get; set; }


        /// <summary>
        /// /重新加载
        /// </summary>
        /// <param name="visibleGradeRange"></param>
        public void Reload(int visibleGradeRange)
        {

        }
    }
}
