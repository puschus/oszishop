using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("WEBSHOPS")]
public class Webshop
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("WEBSHOP_ID",TypeName = "INT")]
    public int WebshopId { get; set; }
    
    [Required]
    [Column("NAME",TypeName = "VARCHAR(45)")]
    public string Name { get; set; }
}