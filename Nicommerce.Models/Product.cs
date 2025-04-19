using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nicommerce.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public string ISBN { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    [DisplayName("List Price")]
    [Range(1, 1000)]
    public double ListPrice { get; set; }
    [Required]
    [Range(1, 1000)]
    public double Price { get; set; }
}
