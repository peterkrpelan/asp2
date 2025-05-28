using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MVC.Models
{
    public class RequestLog
    {
        [Key]
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public required string RequestUrl { get; set; }
        [MaxLength(50)]
        public required string From { get; set; }   


    }
}
