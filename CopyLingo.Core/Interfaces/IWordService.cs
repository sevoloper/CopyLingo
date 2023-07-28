using CopyLingo.Core.Models.Entities;

namespace CopyLingo.Core.Interfaces
{
    public interface IWordService
    {
        Task<List<Word>> GetAllWords();
        Task<List<Word>> AddWord(string English, string Turkish);
        Task<List<Word>> DeleteWord(Word word);
        Task<Word> FindWord(int WordId);
        Task<List<Word>> UpdateWord(Word word);
    }
}
