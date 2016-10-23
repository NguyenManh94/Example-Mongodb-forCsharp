#define async

using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace Example_Mongodb_forCsharp
{
    class clsUsers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        public void Crud_Users(IMongoDatabase exampleDb)
        {
            var userCollection = exampleDb.GetCollection<BsonDocument>("users");

            GetSingleUser(userCollection);
            GetAllUser(userCollection);
            UpdateSingleUser(userCollection);
            UpdateMultipleUser(userCollection);
            DeleteSingleUser(userCollection);
        }

#if async
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void GetSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void GetAllUser(IMongoCollection<BsonDocument> userCollection)
        {

        }
#elif sync
        public void GetAllUser(IMongoCollection<BsonDocument> userCollection)
        {

        }
#else
        /// <summary>
        /// Method: GetSingleUser
        /// Excute: Sync
        /// </summary>
        /// <param name="exampleDb">Example Database</param>
        /// <param name="userCollection">users Collection</param>
        public void GetSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// Method: GetAllUser
        /// Excute: Sync
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void GetAllUser(IMongoCollection<BsonDocument> userCollection)
        {

        }
#endif


#if async
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void InsertSingleUser(IMongoCollection<BsonDocument> userCollection, BsonDocument userDocument)
        {
            await userCollection.InsertOneAsync(userDocument);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void InsertManyUser(IMongoCollection<BsonDocument> userCollection)
        {
            //Tao ra 100 documents cung voi khoang tu 0 => 99, neu lam that thi phai nap chinh xac bang tay
            var documents = Enumerable.Range(0, 100).Select(i => new BsonDocument("counter", i));
            await userCollection.InsertManyAsync(documents);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void UpdateSingleUser(IMongoCollection<BsonDocument> userCollection)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("i", 5);
            var update = Builders<BsonDocument>.Update.Set("i", 110);
            await userCollection.UpdateOneAsync(filter, update);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void UpdateMultipleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public async void DeleteSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }
#else
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void InsertSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void InsertManyUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void UpdateSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void UpdateMultipleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleDb"></param>
        /// <param name="userCollection"></param>
        public void DeleteSingleUser(IMongoCollection<BsonDocument> userCollection)
        {

        }
#endif
    }
}
