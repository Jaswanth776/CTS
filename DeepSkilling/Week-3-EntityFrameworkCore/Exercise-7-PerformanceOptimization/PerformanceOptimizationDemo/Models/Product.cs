using System.ComponentModel.DataAnnotations;

namespace PerformanceOptimizationDemo.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Stock { get; set; }
}
