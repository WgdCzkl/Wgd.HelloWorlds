namespace Worlds.Model.Dimension.Space.LongitudeAndLatitude
{
    /// <summary>
    /// 星球坐标系
    /// </summary>
    public class PlanetCoordinates
    {
        public PlanetCoordinates(decimal lat, decimal lon, decimal height)
        {
            Lat = new Latitude(lat);
            Lon = new Longitude(lon);
            Height = new CenterDistance(height);
        }

        /// <summary>
        /// 经度
        /// </summary>
        public Latitude Lat { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public Longitude Lon { get; set; }

        /// <summary>
        /// 球心距
        /// </summary>
        public CenterDistance Height { get; set; }


        public override string ToString()
        {
            return string.Format("经度{0}纬度{1}球心距{2}", Lat, Lon, Height);
        }
    }
}
