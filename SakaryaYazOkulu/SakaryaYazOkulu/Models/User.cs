using System.ComponentModel.DataAnnotations;

namespace SakaryaYazOkulu.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
