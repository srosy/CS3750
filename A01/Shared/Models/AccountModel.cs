﻿using System.ComponentModel.DataAnnotations;

namespace A01.Shared.Models
{
    public class AccountModel
    {
        public AuthModel Auth { get; set; } = new AuthModel();

        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }
    }
}
