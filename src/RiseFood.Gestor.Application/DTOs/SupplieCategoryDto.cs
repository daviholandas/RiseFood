using System;
using System.ComponentModel.DataAnnotations;

namespace RiseFood.Gestor.Application.DTOs
{
    public class SupplieCategoryDto
    {
       
        [Key]
        public string Code { get; set; }
        public string CategoryName { get; set; }
    }
}
