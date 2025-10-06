namespace Film.Kom
{
    internal class User
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
    }
}
