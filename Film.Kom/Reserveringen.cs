using MongoDB.Bson;
using MongoDB.Driver;

namespace Film.Kom
{
    public class Stoel
    {
        public string Rij { get; set; }
        public int Nummer { get; set; }
    }

    public class Reservering
    {
        public ObjectId Id { get; set; }
        public ObjectId VertoningId { get; set; }
        public ObjectId KlantId { get; set; }
        public List<Stoel> Stoelen { get; set; }
        public bool Betaald { get; set; }
        public DateTime GemaaktOp { get; set; }
    }

    public class ReserveringService
    {
        private readonly IMongoCollection<Reservering> _reserveringen;

        public ReserveringService()
        {
            var client = new MongoClient("mongodb+srv://rickgeerdink2020_db_user:HWTyu7e8IBTBWhTT@cluster0.bi1idnh.mongodb.net/");
            var db = client.GetDatabase("Vilm");

            _reserveringen = db.GetCollection<Reservering>("Reserveringen");

            MaakUniekeStoelIndex();
        }

        private void MaakUniekeStoelIndex()
        {
            var indexKeys = Builders<Reservering>.IndexKeys
                .Ascending(r => r.VertoningId)
                .Ascending("Stoelen.Rij")
                .Ascending("Stoelen.Nummer");

            var indexOptions = new CreateIndexOptions { Unique = true };
            var indexModel = new CreateIndexModel<Reservering>(indexKeys, indexOptions);

            _reserveringen.Indexes.CreateOne(indexModel);
        }

        public void MaakReservering(ObjectId klantId, ObjectId vertoningId, List<Stoel> stoelen)
        {
            var reservering = new Reservering
            {
                KlantId = klantId,
                VertoningId = vertoningId,
                Stoelen = stoelen,
                Betaald = false,
                GemaaktOp = DateTime.Now
            };

            try
            {
                _reserveringen.InsertOne(reservering);
                MessageBox.Show("✅ Reservering toegevoegd!");
            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                MessageBox.Show("❌ Deze stoel is al gereserveerd voor deze vertoning.");
            }
        }
    }
}
