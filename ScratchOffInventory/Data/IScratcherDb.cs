

using ScratchOffInventory.Models;

namespace ScratchOffInventory.Data;

public interface IScratcherDb
{
    Task<List<Card>> GetCardsAsync();
    Task<Card> GetCardAsync(int id);
    Task<int> SaveCardAsync(Card item);
    Task<int> UpdateCardAsync(Card item);
    Task<int> DeleteCardAsync(Card item);

}
