using System.ComponentModel.DataAnnotations;
namespace ProductsCategories.Models;
#pragma warning disable CS8618

public class Category
{
    [Key]
    public int CategoryId {get;set;}
    [Required]
    public string Name {get;set;}
    public List<Association> Associations {get; set;} = new List<Association>();
    public DateTime Created_At {get;set;} = DateTime.Now;
    public DateTime Updated_At {get;set;} = DateTime.Now;

}
