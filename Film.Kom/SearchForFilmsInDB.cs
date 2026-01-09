using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film.Kom
{
    // Wiebe
    internal class SearchForFilmsInDB
    {
        readonly Passwords passwords = new();
        internal async Task<FilmInfo> SearchFunction(string input)
        {
            string FilmName = input.Trim().ToLower();
            var DBClient = new MongoClient(passwords.Database);
            var db = DBClient.GetDatabase("Vilm");
            var Films = db.GetCollection<FilmInfo>("Films");

            var QueryResult = Films.Find(x => x.Title.ToLower() == FilmName).FirstOrDefault();
            if (QueryResult == null)
            {
                return null;
            }
            return QueryResult;
        }
    }
}
