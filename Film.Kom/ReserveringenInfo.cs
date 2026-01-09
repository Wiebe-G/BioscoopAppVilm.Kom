using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Film.Kom
{
    // Wiebe
    public class ReserveringenInfo()
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string ReserveringTitle { get; set; } = string.Empty;
        public string[] Stoelen { get; set; } = Array.Empty<string>();
        public string Zaal { get; set; } = string.Empty;
        public string Datum { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public DateTimeOffset OrderedAt { get; set; }
    }
}
