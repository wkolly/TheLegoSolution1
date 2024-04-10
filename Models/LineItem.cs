using System.ComponentModel.DataAnnotations;

namespace TheLegoSolution1.Models;

public class LineItem
{
    [Key]
    public int TransactionId { get; set; }

    [Key]
    public int ProductId { get; set; }

    public int? Qty { get; set; }

    public int? Rating { get; set; }
}