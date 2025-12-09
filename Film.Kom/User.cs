using MongoDB.Bson.Serialization.Attributes;

namespace Film.Kom
{
    [BsonIgnoreExtraElements]
    internal class User
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public DateTimeOffset RegisteredAt { get; set; }
        public DateTimeOffset Geboortedatum { get; set; }
        public int Rol { get; set; }
    }
}
