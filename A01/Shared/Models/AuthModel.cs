﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace A01.Shared.Models
{
    public class AuthModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)] public string Password { get; set; }
    }
}
