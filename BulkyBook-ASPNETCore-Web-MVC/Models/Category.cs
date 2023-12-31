﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook_ASPNETCore_Web_MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Dispaly Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
