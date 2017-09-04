using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.Space.LongitudeAndLatitude;
using Worlds.Model.Dimension.Time;

namespace Worlds.Model.Civilization.Passport
{
    /// <summary>
    /// 宇宙护照
    /// </summary>
    public class CosmicPassport
    {

        /// <summary>
        /// 护照编号
        /// </summary>
        public string PassportNo { get; set; }

        /// <summary>
        /// 星球编号
        /// </summary>
        public string PlanetNo { get; set; }

        /// <summary>
        /// 降临时间
        /// </summary>
        public YuanTime ComeOnTime { get; set; }

        /// <summary>
        /// 降临地点
        /// </summary>
        public PlanetCoordinates ComeOnPlace { get; set; }

        /// <summary>
        /// 身份等级
        /// </summary>
        public int IdentityLevel { get; set; }




    }
}
