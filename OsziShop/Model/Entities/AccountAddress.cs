using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ACCOUNT_has_ADDRESS_JT")]
public class AccountAddress
{
    [Required]
    [Column("USERNAME", TypeName = "VARCHAR(45)")]
    public string Username { get; set; }

    public Account Account { get; set; }
    
    [Required]
    [Column("ADDRESS_ID",TypeName = "INT")]
    public int AddressId { get; set; }
    public Address Address { get; set; }
}