using MongoDB.Driver;

namespace ConvertXmlIntoMongoDb
{
   public class MongoDataContext
    {
        protected static IMongoDatabase MongoDb;

        public MongoDataContext()
        {
            var client = new MongoClient();
            MongoDb = client.GetDatabase("LvsData");
            var collection = MongoDb.GetCollection<LvsMeasurementResult>("LvsMeasurmentResaults");
        }

        public IMongoCollection<LvsMeasurementResult> LvsMeasurmentResaults
        {
            get { return MongoDb.GetCollection<LvsMeasurementResult>("LvsMeasurmentResault"); }
        }

    }
}
