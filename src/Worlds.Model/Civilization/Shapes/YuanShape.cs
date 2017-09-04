using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Dimension.Space.LongitudeAndLatitude;

namespace Worlds.Model.Civilization.Shapes
{
    /// <summary>
    /// 外形
    /// </summary>
    public class YuanShape : Yuan
    {
        /// <summary>
        /// 中心点坐标
        /// </summary>
        public PlanetCoordinates CenterPointCoordinates { get; set; }

        /// <summary>
        /// 边界坐标值集合
        /// </summary>
        public List<PlanetCoordinates> BoundaryCoordinatePoints { get; set; }
    }
}
