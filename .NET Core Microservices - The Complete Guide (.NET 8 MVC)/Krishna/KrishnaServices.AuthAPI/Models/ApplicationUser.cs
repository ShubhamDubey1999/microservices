using Microsoft.AspNetCore.Identity;

namespace KrishnaServices.AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
