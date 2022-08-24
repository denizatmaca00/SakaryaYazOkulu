using System.ComponentModel.DataAnnotations;

namespace SakaryaYazOkulu.Models
{
    public class Owned
    {
        [Key]
        public int OwnedId { get; set; }
        [Required]
        public int UserId { get; set; }
        public int AnimalId { get; set; }

        public bool IsOwned { get; set; }
    }
}
