using HelloWorlds.Infrastructure.ServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Passport;

namespace HelloWorlds.AccountService
{
    public interface IAccountService
    {


        Response<CosmicPassport> GetCosmicPassport(string idNumber,string passWorld);

        Response<CosmicPassport> GetCosmicPassportByUserName(string userName, string passWorld);
    }
}
