using System.ComponentModel.DataAnnotations;

namespace A01.Data.Models
{
    public class Authentication
    {
        [Key]
        public int AuthId { get; set; }
        public int AccountId { get; set; }
        public string Password { get; set; }
    }
}
