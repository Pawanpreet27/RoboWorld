using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RoboWorld.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "admin@test.com";
        private const string adminPassword = "Secret123$";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppIdentityDbContext context = app.ApplicationServices.GetRequiredService<AppIdentityDbContext>();
            context.Database.Migrate();
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                await userManager.CreateAsync(new IdentityUser("admin@test.com"), adminPassword);
                await userManager.CreateAsync(new IdentityUser("admin2@test.com"), "SomePassw0rd@");
                await userManager.CreateAsync(new IdentityUser("admin3@test.com"), "NewPassw0rd@");
                await userManager.CreateAsync(new IdentityUser("admin4@test.com"), "NewAdmin123@");
                await userManager.CreateAsync(new IdentityUser("admin5@test.com"), "Admin123@");
            }
        }
    }
}
