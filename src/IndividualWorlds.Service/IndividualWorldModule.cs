using Autofac;
using IndividualWorlds.Service.Humans;
using IndividualWorlds.Service.Planets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWorlds.Service
{
    public class IndividualWorldModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region 人类世界

            builder.RegisterType<HumanWorldService>().As<IHumanWorldService>().InstancePerLifetimeScope();
            #endregion


            #region 星球世界
            builder.RegisterType<PlanetWorldService>().As<IPlanetWorldService>().InstancePerLifetimeScope();
            
            #endregion
        }
    }
}
