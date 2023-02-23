using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ADDRESSES")]
public class Address
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ADDRESS_ID", TypeName = "INT")]
    public int AddressId { get; set; }

    [Required]
    [Column("STATE", TypeName = "VARCHAR(45)")]
    public string State { get; set; }
    
    [Required]
    [Column("POSTAL_CODE", TypeName = "INT")]
    public int PostalCode { get; set; }
    
    [Required]
    [Column("CITY", TypeName = "VARCHAR(45)")]
    public string City { get; set; }
    
    [Column("STREET", TypeName = "VARCHAR(45)")]
    public string Street { get; set; }
    
    [Required]
    [Column("STREET_NUMBER", TypeName = "INT")]
    public int StreetNumber { get; set; }
    
    [Required]
    [Column("COUNTRY_NAME")]
    public ECountry Country { get; set; }
    
    public Order OrderDelivery { get; set; }
    public Order OrderBilling { get; set; }
}