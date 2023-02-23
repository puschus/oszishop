using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Model.Entities;

[Table("ORDERS")]
public class Order
{
    [Key]
    [Column("ORDER_ID",TypeName = "INT")]
    public int OrderId { get; set; }
    
    [Required]
    [Column("ORDERING_TIME",TypeName = "DATETIME")]
    public DateTime OrderingTime { get; set; }
    
    public int BillingAddress { get; set; } //Foreign Keys
    public int DeliveryAddress { get; set; }
    
    public Account Account { get; set; }
    public string UserName { get; set; }
}