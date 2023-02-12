using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Core.Defaults;
using Assets.Core.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using UnityEngine.TextCore.Text;

namespace Assets
{
    public class MongoConnection
    {
        private IMongoDatabase _database;

        public MongoConnection()
        {
            var client = new MongoClient("mongodb://localhost");
            _database = client.GetDatabase("UnityQuiz");
        }

        public void AddToDataBase(User user)
        {
            var collection = _database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }

        public User GetUserFromDataBase()
        {
            var collection = _database.GetCollection<User>("UserCollection");

            var result =  collection.Find(new BsonDocument()).FirstOrDefault();

            if(result == null)
            {
                AddToDataBase(DefaultUser.defaultUser);
                GetUserFromDataBase();
            }

            return result;
        }

        public void RefreshUserData(User newUser)
        {
            var collection = _database.GetCollection<User>("UserCollection");

            collection.ReplaceOne(new BsonDocument(), newUser);
        }
    }
}
