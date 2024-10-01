using System.ComponentModel.DataAnnotations;

namespace OnatrixCMS.ViewModels
{
    public class EmailViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = null!;
    }
}
