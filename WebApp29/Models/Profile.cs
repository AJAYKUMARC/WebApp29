using System.ComponentModel.DataAnnotations;

namespace WebApp29.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        public DateTime DateofBirth { get; set; }

        public string PlaceofBirth { get; set; }
    }
}
