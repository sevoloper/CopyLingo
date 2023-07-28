using CopyLingo.Core.Interfaces;
using CopyLingo.Core.Models;
using CopyLingo.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CopyLingo.Core.Services
{
    public class WordService: IWordService
    {
        private readonly DatabaseContext databaseContext;

        public WordService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public async Task<List<Word>> GetAllWords()
        {
            return await databaseContext.TblWorldList.ToListAsync();
        }

        public async Task<List<Word>> AddWord(string English, string Turkish)
        {
            var newWord = new Word
            {
                English = English,
                Turkish = Turkish
            };
            
            databaseContext.TblWorldList.Add(newWord);
            databaseContext.SaveChanges();

            return await GetAllWords();
        }

        public async Task<List<Word>> DeleteWord(Word word)
        {
            databaseContext.TblWorldList.Remove(word);
            databaseContext.SaveChanges();
            return await GetAllWords();
        }

        public async Task<Word> FindWord(int WordId)
        {
            var q = await databaseContext.TblWorldList.FindAsync(WordId);
            return q!;
        }

        public async Task<List<Word>> UpdateWord(Word word)
        {
            var wordQuery = await FindWord(word.Id);

            wordQuery.Turkish = word.Turkish;
            wordQuery.English = word.English;

            databaseContext.TblWorldList.Update(wordQuery);
            databaseContext.SaveChanges();
            return await GetAllWords();
        }

    }
}
