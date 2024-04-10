using System.ComponentModel.DataAnnotations;

namespace TheLegoSolution1.Models;

public class Recommendation
{
    [Key]
    public int? ProductId { get; set; }
    
    public string? Name { get; set; }
    
    public int PopScore { get; set; }
    
    public string? Rec1 { get; set; }
    public string? Rec2 { get; set; }
    public string? Rec3 { get; set; }
    public string? Rec4 { get; set; }
    public string? Rec5 { get; set; }
}