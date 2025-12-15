using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Film.Kom
{
    internal class FilmInfo
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Poster { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
        public string Rated { get; set; } = string.Empty;
        public string Runtime { get; set; } = string.Empty;
        public string Speeltijd { get; set; } = string.Empty;
        public string Zaal { get; set; } = string.Empty;
        public List<string> ReservedSeats { get; set; } = new List<string>();
    }
}