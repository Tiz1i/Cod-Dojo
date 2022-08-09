#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CrudDelicious.Models;
public class Dish
{
    [Key]
    public int DishId { get; set; }
    
    [Required]
    [Display(Name = "Chef's Name")]
    public string ChefsName { get; set; } 

    [Required]
    [Display(Name ="Name of the Dish")]
    public string NameOfDish { get; set; }

    [Required]
    [Range(0, 10000000)]
    public int Calories { get; set; }

    [Required]
    [Range(1, 6)]
    public int Tastiness { get; set;}

    [Required]
    [Display(Name ="Description")]
    public string Descriptions { get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
