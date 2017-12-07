using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SamsungEncryptServer.Models
{
    public class Step1Request
    {
        [Required]
        public string pin { get; set; }

        [Required]
        public string deviceId { get; set; }
    }
}