using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film.Kom
{
    internal class SearchForFilmsInDB
    {
        Passwords passwords = new Passwords();
        internal async Task<FilmInfo> SearchFunction(string input)
        {
            string FilmName = input.Trim().ToLower();
            // vervang FilmName voor input, en zet dit naar aparte class
            var DBClient = new MongoClient(passwords.Database);
            var db = DBClient.GetDatabase("Vilm");
            var Films = db.GetCollection<FilmInfo>("Films");

            var QueryResult = Films.Find(x => x.Title.ToLower() == FilmName).FirstOrDefault();
            if (QueryResult == null)
            {
                MessageBox.Show($"Film {FilmName} draait helaas niet, of heeft een andere naam. Probeer een andere.");
                return null;
            }
            return QueryResult;
        }
    }
}
