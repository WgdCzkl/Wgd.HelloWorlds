using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetWorlds.Model;
using Worlds.Model.Dimension.SpaceTime;
using Worlds.Model;
using Worlds.Model.Macroscopic.CivilizedCreation;
using Worlds.Model.Civilization.Areas;

namespace IndividualWorlds.Service.Planets
{
    public class PlanetWorldService : IPlanetWorldService
    {
        /// <summary>
        /// 获取星球世界
        /// </summary>
        /// <param name="planetNo"></param>
        /// <param name="planetSpaceTime"></param>
        /// <returns></returns>
        public PlanetWorld GetPlanetWorld(PlanetSpaceTime planetSpaceTime)
        {
            PlanetWorld planetWorld = new PlanetWorld() { Areas = GetAreas() };


            return planetWorld;
        }

        /// <summary>
        /// 加载星球世界基础信息
        /// </summary>
        /// <param name="planetNo"></param>
        /// <param name="planetSpaceTime"></param>
        /// <returns></returns>
        public PlanetWorldBaseInfo CongfigLoad(PlanetSpaceTime planetSpaceTime)
        {
            PlanetWorldBaseInfo worldBaseInfo = new PlanetWorldBaseInfo();
            worldBaseInfo.AreaTypes = GetAreaTypes();

            return worldBaseInfo;
        }

        #region 加载数据
        /// <summary>
        /// 加载 区域类型
        /// </summary>
        private static List<AreaType> GetAreaTypes()
        {
            List<AreaType> areaTypes = new List<AreaType>();
            areaTypes.Add(new AreaType("洲"));
            areaTypes.Add(new AreaType("国"));
            areaTypes.Add(new AreaType("省"));
            areaTypes.Add(new AreaType("市"));
            areaTypes.Add(new AreaType("县"));
            areaTypes.Add(new AreaType("镇"));
            areaTypes.Add(new AreaType("行政村"));
            areaTypes.Add(new AreaType("自然村"));
            return areaTypes;
        }

        /// <summary>
        /// 获取区域
        /// </summary>
        /// <returns></returns>
        public static List<YuanArea> GetAreas()
        {
            List<YuanArea> areas = new List<YuanArea>();
            areas.Add(new YuanArea("杨浦区") { SubAreas = GetSubAreas("杨浦区"), Roads = GetRoads("杨浦区") });
            areas.Add(new YuanArea("宝山区") { SubAreas = GetSubAreas("宝山区"), Roads = GetRoads("宝山区") });
            return areas;
        }

        /// <summary>
        /// 获取区域
        /// </summary>
        /// <returns></returns>
        public static List<YuanArea> GetSubAreas(string areaName)
        {
            List<YuanArea> areas = new List<YuanArea>();

            areas.Add(new YuanArea("创智天地企业中心") { Architectures = GetArchitectures("创智天地企业中心") });
            areas.Add(new YuanArea("新江湾佳苑") { Architectures = GetArchitectures("新江湾佳苑") });
            return areas;
        }

        /// <summary>
        /// 获取建筑
        /// </summary>
        /// <param name="areaName"></param>
        /// <returns></returns>
        public static List<YuanArchitecture> GetArchitectures(string areaName)
        {
            List<YuanArchitecture> architectures = new List<YuanArchitecture>();
            switch (areaName)
            {
                case "创智天地企业中心":
                    architectures.Add(new YuanArchitecture("1号楼"));
                    architectures.Add(new YuanArchitecture("2号楼"));
                    break;
                case "新江湾佳苑":
                    architectures.Add(new YuanArchitecture("35号"));
                    architectures.Add(new YuanArchitecture("36号"));
                    break;
                default:
                    break;
            }

            return architectures;
        }


        /// <summary>
        /// 获取道路
        /// </summary>
        /// <param name="areaName"></param>
        /// <returns></returns>
        public static List<YuanRoad> GetRoads(string areaName)
        {
            List<YuanRoad> roads = new List<YuanRoad>();
            roads.Add(new YuanRoad("政立路"));
            roads.Add(new YuanRoad("淞沪路"));
            roads.Add(new YuanRoad("政学路"));
            return roads;
        }

        #endregion

    }
}
