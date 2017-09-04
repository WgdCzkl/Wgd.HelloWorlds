using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorlds.AccountService
{
    public class AccountModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region  用户

            builder.RegisterType<AccountService>().As<IAccountService>().InstancePerLifetimeScope();
            #endregion
        }
    }
}
