using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.Quality;
using Worlds.Model.Dimension.Time;
using Worlds.Model.Dimension.Volume;

namespace Worlds.Model.Dimension.Space
{
    /// <summary>
    /// 星球
    /// </summary>
    public class Planet : Yuan
    {
        #region 初始化
        public Planet(YuanQuality quality, YuanLength longRadius, YuanLength shortRadius, Planet revolutionPlanet)
        {
            Quality = quality;
            LongRadius = longRadius;
            ShortRadius = shortRadius;
            RevolutionPlanet = revolutionPlanet;
        }
        #endregion

        #region 自然属性
        /// <summary>
        /// 质量
        /// </summary>
        public YuanQuality Quality { get; set; }

        /// <summary>
        /// 长半径
        /// </summary>
        public YuanLength LongRadius { get; set; }

        /// <summary>
        /// 短半径
        /// </summary>
        public YuanLength ShortRadius { get; set; }
        #endregion

        #region  关系属性
        /// <summary>
        /// 公转行星
        /// </summary>
        public Planet RevolutionPlanet { get; set; }

        #endregion

        #region 对外属性

        /// <summary>
        /// 星球编号
        /// </summary>
        public long PlanetNo { get; set; }

        /// <summary>
        /// 所属星系
        /// </summary>
        public Galaxy Galaxy { get; set; }


        #endregion

        #region 对内属性
        /// <summary>
        /// 内部名称
        /// </summary>
        public string InnerName { get; set; }


        /// <summary>
        /// 公转时间
        /// </summary>
        public YuanTime RevolutionTime
        {
            get
            {
                if (RevolutionPlanet != null && Quality != null)
                {
                    return RevolutionPlanet.Quality / this.Quality;
                }
                return 365;
            }
        }



        /// <summary>
        /// 自转时间
        /// </summary>
        public YuanTime RotationTime
        {
            get
            {
                return 1;
            }
        }
        #endregion


        /// <summary>
        /// 获取大概时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public YuanTime GetYuanTime(PlanetTime time)
        {
            return RevolutionTime.Value * time.RevolutionNumber + RotationTime.Value * time.RotationNumber;
        }
    }
}
