using System.ComponentModel.DataAnnotations;

namespace LearningVersion6.Models
{
    public class User
    {
        [Required]
        public int ID { get; set; }
        public string? Name { get; set; }

        //[MinLength(1), MaxLength(10, ErrorMessage = "The Value is not Right")]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}