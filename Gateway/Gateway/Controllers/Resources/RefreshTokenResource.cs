﻿using System.ComponentModel.DataAnnotations;

namespace Gateway.Controllers.Resources
{
    public class RefreshTokenResource
    {
        [Required]
        public string Token { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string UserEmail { get; set; }
    }
}
