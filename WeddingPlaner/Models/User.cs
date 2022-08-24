#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlaner.Models;
public class User
{
    
    [Key]
    public int UserId { get; set; } 
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; } 
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password { get; set; } 
    [Range(0,double.MaxValue)]
    public int Balance { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

     public List<Wedding> MyWeddins { get; set; } = new List<Wedding>(); 

      public List<Invite> Invited  { get; set; } = new List<Invite>();

   
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string Confirm { get; set; } 
}