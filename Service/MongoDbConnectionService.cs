using MongoDB.Driver;

namespace UserProfileAPI.Service
{
    /// <summary>
    /// Service for MongoDb connection
    /// </summary>
    public class MongoDbConnectionService
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<MongoDbConnectionService>();

        /// <summary>
        /// Gets or private Sets Client
        /// </summary>
        public IMongoClient Client { get; private set; }

        /// <summary>
        /// Gets or private Sets Database
        /// </summary>
        public IMongoDatabase Database { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MongoDbConnectionService(IConfiguration config)
        {
            var connectionString = config.GetSection("MongoDB:ConnectionURI").Value;
            var databaseName = config.GetSection("MongoDB:DatabaseName").Value;

            Client = new MongoClient(connectionString);
            Database = Client.GetDatabase(databaseName);
        }
    }
}
