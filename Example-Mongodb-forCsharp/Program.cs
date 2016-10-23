using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Mongodb_forCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var exampleDb = GetDatabase("example");

            var collection = exampleDb.GetCollection<BsonDocument>("teacher");
            var count = collection.Count(new BsonDocument());
            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static IMongoDatabase GetDatabase(string _dbName)
        {
            //Create object connect mongodb server
            //var client = new MongoClient();

            //Connect use a connect string
            var client = new MongoClient("mongodb://localhost:27017");

            return client.GetDatabase(_dbName);
        }
    }
}
