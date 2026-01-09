using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Film.Kom
{
    // Wiebe en Rick
    [BsonIgnoreExtraElements]
    public class User

    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("naam")]
        public string Naam { get; set; } = string.Empty;

        [BsonElement("email")]
        public string Email { get; set; } = string.Empty;

        [BsonElement("hashedPassword")]
        public string HashedPassword { get; set; } = string.Empty;

        [BsonElement("registeredAt")]
        public DateTimeOffset RegisteredAt { get; set; }

        [BsonElement("geboortedatum")]
        public DateTimeOffset Geboortedatum { get; set; }

        [BsonElement("rol")]
        public int Rol { get; set; }
    }
}
