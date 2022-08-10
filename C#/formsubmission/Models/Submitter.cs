#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace formsubmission.Models;

public class Submitter
{
    [Required]
    [MinLength(3)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }


    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Age")]
    public int Age { get; set; }

    [Required]
    [Display(Name = "Email Address")]
    public string EmailAddress { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}