﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Person : IModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
