using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Authors
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Key]
        public int ClientId { get; set; } 
    }
}
