using System.ComponentModel.DataAnnotations;

namespace OnatrixCMS.ViewModels
{
    public class RiskFormViewModel
    {

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Message is required.")]
        public string? Message { get; set; }
    }
}

