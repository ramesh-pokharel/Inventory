using SQLite;
using System.ComponentModel.DataAnnotations;


namespace ScratchOffInventory.Models;
public class Card
{
    [PrimaryKey, AutoIncrement]
    public int Id{get;set;}
    [Required]
    public string? Name{get; set;}= string.Empty;
    [Required]
    public int StartNumber{get; set;}
    [Required]
    public int EndNumber{get; set;}
    [Required]
    public decimal TicketPrice{get; set;}

    /*
    public decimal Amount
    {
        get => _amount;
        set => _amount = (EndNumber - StartNumber)* TicketPrice;
    }

    private decimal _amount;

    */
}