using System;
using Microsoft.AspNetCore.Identity;

namespace RiseFood.App.WebAPi.Models
{
    public class User : IdentityUser
    {
       public string Role { get; set; }
    }
}