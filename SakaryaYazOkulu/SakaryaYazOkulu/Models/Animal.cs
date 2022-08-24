using System.ComponentModel.DataAnnotations;

namespace SakaryaYazOkulu.Models
{
    public class Animal
    {

        [Key]
        public int AnimalId { get; set; }
        [Required]
        public int Old { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string IsBoy { get; set; }
        public string IsOwned { get; set; }
    }
}
