using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Book
    {
        [Key]
        public string Id { get; set; }  
        public string Title { get; set; }
        public string test { get; set; }
    }
}
