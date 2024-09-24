using System.ComponentModel.DataAnnotations;

namespace OnatrixCMS.ViewModels
{
    public class ContactFormViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone is required.")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Service is required.")]
        public string? Service { get; set; } 
    }
}
