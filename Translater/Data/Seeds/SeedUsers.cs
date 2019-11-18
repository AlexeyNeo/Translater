using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Translater.Web.Data.Seeds
{
    public static class SeedUsers
    {
        public static void Seed(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("User").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "user@example.com",
                    Email = "user@example.com",
                };
               var result =  userManager.CreateAsync(user, "123User@").Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(user, "User").Wait();
            }

            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Admin@example.com",
                    Email = "Admin@example.com",
                };
                var result = userManager.CreateAsync(user, "123Admin@").Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(user, "Admin").Wait();
            }
         }
    }
}
