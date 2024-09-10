using SQLite;
using System.ComponentModel.DataAnnotations;


namespace ScratchOffInventory.Models;
public class Card
{
    [PrimaryKey, AutoIncrement]
    public int Id{get;set;}
    
    [Required(AllowEmptyStrings = false)]
    [Length(2, 50, ErrorMessage ="Must be between 2 and 50")]
    public string? Name{get; set;}
    [Required]
    public int StartNumber{get; set;}
    [Required]
    public int EndNumber{get; set;}
    [Required]
    public decimal TicketPrice{get; set;}

}