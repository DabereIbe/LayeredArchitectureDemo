﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DomainModels.Users
{
    public class UsersCreateDto
    {
        [Required]
        public string Name { get; set; }

        public int Code { get; set; }
    }
}
