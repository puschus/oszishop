using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ARTICLE_has_CATEGORY_JT")]
public class ArticleCategory
{
    [Required]
    [Column("ARTICLE_ID", TypeName = "INT")]
    public int ArticleId { get; set; }

    public Article Article { get; set; }
    
    [Required]
    [Column("CATEGORY_ID",TypeName = "INT")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}