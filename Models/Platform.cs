using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Plataform
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string publisher { get; set; }

        [Required]
        public string cost { get; set; }
    }
}