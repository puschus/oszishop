using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("CATEGORIES")]
public class Category
{
    [Key]
    [Column("CATEGORY_ID",TypeName = "INT")]
    public int CategoryId { get; set; }
    
    [Required]
    [Column("DESIGNATION",TypeName = "VARCHAR(45)")]
    public string Designation { get; set; }
    
    public Category ParentCategory { get; set; }
    
    public int ParentCategoryId { get; set; } //Foreign Key
}