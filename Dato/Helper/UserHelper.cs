namespace Dato.Helper
{
    using Dato.ModelsCore.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;

        public UserHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByMailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }

    }
}
