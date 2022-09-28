using System.ComponentModel.DataAnnotations.Schema;
namespace Project_Blazor.Models
{
    public class Order
    {
        [ForeignKey("Product")]
        public int Idd_prod { get; set; }
        [ForeignKey("Customer")]
        public int Idd_cust { get; set; }
        public int QTY { get; set; }
        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
