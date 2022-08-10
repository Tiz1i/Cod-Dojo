using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models

{

    public class Submitter

    {

        [Display(Name="First Name")]

        [Required]

        [MinLength(4, ErrorMessage="Field must be 4 characters or more")]

        public string FirstName {get;set;}

        [Display(Name="Last Name")]

        [Required]

        [MinLength(4, ErrorMessage="Field must be 4 characters or more")]

        public string LastName {get;set;}

        [Range(0, Int32.MaxValue, ErrorMessage="Age must be a positive number")]

        [Required]

        public int Age {get;set;}

        [Display(Name="Email Address")]

        [Required]

        [EmailAddress]
        

        public string Email {get;set;}

        [DataType(DataType.Password)]

        [MinLength(8, ErrorMessage="Field must be 8 characters or more")]

        public string Password {get;set;}

    }

}