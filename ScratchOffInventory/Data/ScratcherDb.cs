


using ScratchOffInventory.Models;
using SQLite;

namespace ScratchOffInventory.Data;

public class ScratcherDb: IScratcherDb
{
    SQLiteAsyncConnection Database;

    public ScratcherDb()
    {
        
    }

    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
       
        var result = await Database.CreateTableAsync<Card>();
        await Database.EnableWriteAheadLoggingAsync();
    }


    public async Task<List<Card>> GetCardsAsync()
    {
        await Init();
        return await Database.Table<Card>().ToListAsync();
    }

   

    public async Task<Card> GetCardAsync(int id)
    {
        await Init();
        return await Database.Table<Card>().Where(i => i.Id == id).FirstOrDefaultAsync();
    }

    public async Task<int> SaveCardAsync(Card item)
    {
        await Init();        
        item.Id = 0;
        return await Database.InsertAsync(item);
        
    }

    public async Task<int> UpdateCardAsync(Card item)
    {
        await Init();
        return await Database.UpdateAsync(item);
    }

    public async Task<int> DeleteCardAsync(Card item)
    {
        await Init();
        return await Database.DeleteAsync(item);
    }

    /*
   public async Task<List<Card>> GetItemsNotDoneAsync()
   {
       await Init();
       return await Database.Table<Card>().Where(t => t.Done).ToListAsync();

       // SQL queries are also possible
       //return await Database.QueryAsync<Card>("SELECT * FROM [Card] WHERE [Done] = 0");
   }
   */

}
