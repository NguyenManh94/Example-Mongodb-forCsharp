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

            Console.WriteLine("Danh Sach Giao Vien la");
            foreach (var item in collection.Find(new BsonDocument()).ToList())
            {
                Console.WriteLine(item);
            }

            //=============================
            Console.WriteLine("Giao vien dau tien trong danh sach la");
            var teacherFirst = collection.Find(new BsonDocument()).First();
            //var teacherFirst_ = collection.Find(new BsonDocument()).FirstOrDefault();
            Console.WriteLine(teacherFirst);
            var count = collection.Count(new BsonDocument());
            Console.WriteLine(count);

            //Console.WriteLine("Get all teacher");
            //GetAllTeacher(exampleDb);

            var documentss = Enumerable.Range(0, 100).Select(i => new BsonDocument("counter", i));
            foreach (var item in documentss)
            {
                Console.WriteLine(item);
            }
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

        public static void GetAllTeacher(IMongoDatabase exampleDb)
        {
            var teacher = exampleDb.GetCollection<BsonDocument>("teacher");
            var cursor = teacher.Find(new BsonDocument()).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                Console.WriteLine(document);
            }
        }

        public static void GetSingleTeacher(IMongoDatabase exampleDb)
        {
            var teacher = exampleDb.GetCollection<BsonDocument>("teacher");
            //var cusor =
        }
    }
}
