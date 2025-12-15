using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Film.Kom
{
    internal class ReserveringenInfo()
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string ReserveringTitle { get; set; } = string.Empty;
        internal string[] Stoelen { get; set; } = Array.Empty<string>();
        internal string Zaal { get; set; } = string.Empty;
        internal string Datum { get; set; } = string.Empty;
        internal string CustomerName { get; set; } = string.Empty;
        internal double Price { get; set; }
        internal DateTimeOffset OrderedAt { get; set; }

    }
}
