using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class ProductPOS
{
    public int Id { get; set; } // Auto-generated
    public int ProductId { get; set; } // Unique
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string PriceUnit { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public string StockUnit { get; set; }
}
