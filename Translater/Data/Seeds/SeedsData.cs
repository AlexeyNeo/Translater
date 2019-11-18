using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Translater.Web.Data.Seeds
{
    public static class SeedData
    {
        public static void Seeds(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles.Seed(roleManager);
            SeedUsers.Seed(userManager);
         }

    }
}
