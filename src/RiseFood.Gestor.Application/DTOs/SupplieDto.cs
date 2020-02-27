using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Application.DTOs
{
    public class SupplieDto
    {
        [Key]
        public int Id { get; set;}
        public string Code { get; set; }
        public string SupplieName { get; set; }
        public decimal Price { get; set; }
        public string SupplieCategory { get; set; }
    }
}
