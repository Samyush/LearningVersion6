using System.ComponentModel.DataAnnotations;

namespace LearningVersion6.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }

        [MinLength(1), MaxLength(10, ErrorMessage = "The Value is not Right")]
        public int PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
