﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace CashGen.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserLevel { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public Guid ResetToken { get; set; }
        public bool LiveChat { get; set; }
        public bool Accounting { get; set; }
    }

}
