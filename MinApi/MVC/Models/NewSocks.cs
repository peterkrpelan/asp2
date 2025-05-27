using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class NewSocks
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Brand { get; set; }

        public SockSize Size { get; set; }
        [Range(0.5, 100)]
        public decimal Price { get; set; }
        [Range(0, 10000)]
        public int OnStock { get; set; }

    }
}
