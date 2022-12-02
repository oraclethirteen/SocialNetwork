using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SocialNetwork.ViewModels.Account
{
    public class SearchViewModel
    {
        public List<UserWithFriendExt> UserList { get; set; }

    }
}
