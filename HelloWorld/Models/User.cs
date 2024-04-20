using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class User
    {
        [Display(Name = "Enter your name:")]
        [Required(ErrorMessage = "The field is not filled!")]
        public string Name { get; set; }
    }
}
