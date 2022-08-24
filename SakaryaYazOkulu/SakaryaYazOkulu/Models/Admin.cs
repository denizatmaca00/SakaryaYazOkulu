using System.ComponentModel.DataAnnotations;

namespace SakaryaYazOkulu.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
