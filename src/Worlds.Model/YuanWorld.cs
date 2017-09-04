using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.SpaceTime;

namespace Worlds.Model
{
    /// <summary>
    /// 元世界
    /// </summary>
    public class YuanWorld : Yuan
    {

        #region 自身属性
        /// <summary>
        /// 载体
        /// </summary>
        public virtual Object Carrier { get; set; }

        /// <summary>
        /// 子世界
        /// </summary>
        public List<YuanWorld> SubWorlds { get; set; }

        /// <summary>
        /// 父世界
        /// </summary>
        public YuanWorld ParentWorlds { get; set; }

        /// <summary>
        /// 外部世界
        /// </summary>
        public YuanWorld OutsideWorld { get; set; }

        /// <summary>
        /// 世界等级
        /// </summary>
        public int WorldGrade { get; set; }
        #endregion

        #region 参照属性
        /// <summary>
        /// 当前时空
        /// </summary>
        public YuanSpaceTime CurrSpanceTime { get; set; }
        #endregion

        #region 可见频段范围
        /// <summary>
        /// 可见频段范围
        /// </summary>
        public int VisibleBandRange { get; set; }
        #endregion

        #region 重新加载
        /// <summary>
        /// 重新加载
        /// </summary>
        /// <param name="worldGrade">级别</param>
        /// <returns></returns>
        public new Boolean Reload(int worldGrade)
        {
            return Reload(worldGrade, CurrSpanceTime);
        }
        /// <summary>
        /// 重新加载
        /// </summary>
        /// <param name="worldGrade">级别</param>
        /// <returns></returns>
        public Boolean Reload(int worldGrade, YuanSpaceTime spaceTime)
        {
            return true;
        }

        #endregion

        #region 演化
        public void AddSubWorld(YuanWorld world)
        {
            SubWorlds.Add(world);
        }
        #endregion

    }


    public class YuanWorld<T> : YuanWorld
    {
        /// <summary>
        /// 载体
        /// </summary>
        public new T Carrier { get; set; }
    }
}
