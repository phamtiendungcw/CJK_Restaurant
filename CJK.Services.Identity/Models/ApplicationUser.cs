using Microsoft.AspNetCore.Identity;

namespace CJK.Services.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
    }
}
