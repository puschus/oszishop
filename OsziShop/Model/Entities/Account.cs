using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Model.Entities;

[Table("ACCOUNTS")]
public class Account : IdentityUser
{
    [Required]
    [Column("FIRST_NAME", TypeName = "VARCHAR(50)")]
    public string FirstName { get; set; }
    
    [Required]
    [Column("LAST_NAME", TypeName = "VARCHAR(50)")]
    public string LastName { get; set; }

    [Required]
    [Column("PAYMENT_ID", TypeName = "INT")]
    public int PaymentId { get; set; }
    
    public Order Order { get; set; }
}