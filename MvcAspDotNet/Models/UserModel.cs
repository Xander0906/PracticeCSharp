﻿using System.ComponentModel.DataAnnotations;

namespace MvcAspDotNet.Models
{
    public class UserModel
    {
        [Key]
        public int? user_id { get; set; }
        public string? firstname { get; set; }
        public  string? middlename { get; set; }
        public string? lastname { get; set; }    
        public string? username { get;set; }
        public string? password { get; set; }
    }
}
