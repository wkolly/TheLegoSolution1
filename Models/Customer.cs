using System.ComponentModel.DataAnnotations;

namespace TheLegoSolution1.Models;

public class Customer
{
    [Key]
    public int? CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? CountryOfResidence { get; set; }

    public string? Gender { get; set; }

    public decimal? Age { get; set; }
}