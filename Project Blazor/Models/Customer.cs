using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project_Blazor.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
