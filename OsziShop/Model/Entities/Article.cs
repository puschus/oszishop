using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ARTICLES")]
public class Article
{
    [Key]
    [Column("ARTICLE_ID",TypeName = "INT")]
    public int ArticleId { get; set; }
    
    [Required]
    [Column("DESIGNATION",TypeName = "VARCHAR(45)")]
    public string Designation { get; set; }
    
    [Required]
    [Column("DESCRIPTION",TypeName = "VARCHAR(45)")]
    public string Description { get; set; }
    
    [Required, Column("PRICE", TypeName = "FLOAT")]
    public float Price { get; set; }
}