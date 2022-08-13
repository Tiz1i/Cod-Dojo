#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsCategories.Models;


public class Products
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [Display(Name ="Name")]
    public string Name { get; set; }
    [Required]
    [Display(Name ="Description")]
    public string Description { get; set; }
    
    [Required]
    [Display(Name ="Price")]
    public float Price { get; set; }
    public List<Association> Associations {get; set;} = new List<Association>();
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}