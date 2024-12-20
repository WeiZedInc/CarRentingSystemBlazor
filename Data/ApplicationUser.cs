using Microsoft.AspNetCore.Identity;

namespace CarRentingSystemBlazor.Data
{
    public enum Role
    {
        User,
        Moderator,
        Admin
    }
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
    }

}