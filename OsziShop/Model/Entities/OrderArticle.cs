using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ORDER_has_ARTICLE_JT")]
public class OrderArticle
{
    [Required]
    [Column("ORDER_ID", TypeName = "INT")]
    public int OrderId { get; set; }

    public Order Order { get; set; }
    
    [Required]
    [Column("ARTICLE_ID",TypeName = "INT")]
    public int ArticleId { get; set; }
    public Article Article { get; set; }
}