using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("WEBSHOP_has_ARTICLE_JT")]
public class WebshopArticle
{
    [Required]
    [Column("PRICE", TypeName = "DECIMAL(5,2)")]
    public decimal Price { get; set; }
    
    [Required]
    [Column("STOCK", TypeName = "INT")]
    public int Stock { get; set; }
    
    [Required]
    [Column("WEBSHOP_ID", TypeName = "INT")]
    public int WebShopId { get; set; }
    
    public Webshop Webshop { get; set; }

    [Required]
    [Column("ARTICLE_ID",TypeName = "INT")]
    public int ArticleId { get; set; }
    
    public Article Article { get; set; }
}