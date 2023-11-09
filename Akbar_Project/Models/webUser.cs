using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Akbar_Project.Models
{
    public class WebUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
    }
}
