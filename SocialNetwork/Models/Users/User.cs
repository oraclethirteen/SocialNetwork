﻿using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MIddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }

        public string Status { get; set; }

        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public User()
        {
            Image = "https://via.placeholder.com/500";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }

    }
}