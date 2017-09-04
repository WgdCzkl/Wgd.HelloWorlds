using HelloWorlds.Infrastructure.ServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worlds.Model.Civilization.Passport;

namespace HelloWorlds.AccountService
{
    public class AccountService : IAccountService
    {
        public Response<CosmicPassport> GetCosmicPassport(string idNumber, string passWorld)
        {
            Response<CosmicPassport> passport = new Response<CosmicPassport>(true, new CosmicPassport() { PassportNo = "4127251992" });
            return passport;
        }

        public Response<CosmicPassport> GetCosmicPassportByUserName(string userName, string passWorld)
        {
            throw new NotImplementedException();
        }


    }
}
