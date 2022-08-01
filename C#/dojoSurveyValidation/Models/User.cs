using System.ComponentModel.DataAnnotations;
namespace dojoSurveyValidation.Models;
#pragma warning disable CS8618
public class User
{
    [Required]
    [MinLength(2)]
    [Display(Name = "Your Name:")]
    public string YourName { get; set; }
    [Required]
    [Display(Name = "Dojo Location:")]
    public string DojoLocation { get; set; }


    [Required]
    [Display(Name = "Favorite Language:")]
    public string FavoriteLanguage { get; set; }


    [Required]
    [MinLength(20)]
    [Display(Name = "Comment")]
    public string Comment { get; set; }

}

