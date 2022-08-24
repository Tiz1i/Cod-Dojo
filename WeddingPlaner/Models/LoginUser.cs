#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlaner.Models;
public class LoginUser
{
    // No other fields!
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
     [DataType(DataType.Password)]
     [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password { get; set; } 
}