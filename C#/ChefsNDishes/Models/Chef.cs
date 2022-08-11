#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
using System.ComponentModel.DataAnnotations.Schema;
public class Chef
{

    [Key]
    public int ChefId { get; set; }
    
    [Required]
    [Display(Name ="Name")]
    public string Name { get; set; }
    [Required]
    [Display(Name ="Last Name")]
    public string LastName { get; set; }
  
   [Required]
   [Display(Name ="DateofBirth")]
    public DateTime DateofBirth { get; set; }
    public List<Dish>? Dishes {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

