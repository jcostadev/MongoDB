using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB 
{
    class Program 
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        static void Main(string[] args) 
        {
                        
            _client = new MongoClient();
            _database = _client.GetDatabase("My_Database");
            var collection = _database.GetCollection<BsonDocument>("MyCollection");

            BsonDocument book = new BsonDocument();
            book.Add("_id", BsonValue.Create(BsonType.ObjectId));
            book.Add("author", "pradhan");
            book.Add("title", "My experience");

            collection.InsertOne(book);
            


           /* BookStore bookStore = new BookStore 
            {
                BookTitle = "MongoDB Basics",
                ISBN = "8767687689898yu",
                Auther = "Tanya",
                Category = "NoSQL DBMS"
            };

            collection.InsertOne(bookStore);*/

        }
    }
}
