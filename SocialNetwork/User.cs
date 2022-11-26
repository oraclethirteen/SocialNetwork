using Microsoft.AspNetCore.Identity;

namespace SocialNetwork
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MIddleName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
