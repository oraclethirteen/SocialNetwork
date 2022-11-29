using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.ViewModels.Account
{
    public class SearchViewModel
    {
        public List<UserWithFriendExt> UserList { get; set; }

    }
}
