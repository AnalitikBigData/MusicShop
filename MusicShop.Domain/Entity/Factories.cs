using System;
namespace Domain.Entity;
using Domain.Enum;
using System.ComponentModel.DataAnnotations;

public class Factories
{
    [Key]
    public int ID_factory { get; set; }
    [Required]
    public string Name_factory { get; set; }
    public string Specialization_factory { get; set; }
    public string Adress_factory { get; set; }
}

