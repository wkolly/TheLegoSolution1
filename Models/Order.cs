using System.ComponentModel.DataAnnotations;

namespace TheLegoSolution1.Models;

public class Order
{
    [Key]
    public int? TransactionId { get; set; }

    public int? CustomerId { get; set; }

    public string? Date { get; set; }

    public string? DayOfWeek { get; set; }

    public int? Time { get; set; }

    public string? EntryMode { get; set; }

    public decimal? Amount { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? CountryOfTransaction { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Bank { get; set; }

    public string? TypeOfCard { get; set; }

    public int? Fraud { get; set; }
}