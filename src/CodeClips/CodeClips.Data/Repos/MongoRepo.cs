using CodeClips.Entities.Clips;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace CodeClips.Data.Repos
{
    public class MongoRepo : IRepo
    {
        MongoClient _client;
        IMongoDatabase _db;
        IMongoCollection<Clip> _clips;

        public MongoRepo(string connection)
        {
            _client = new MongoClient("mongodb://remote.ianhodg.es:27017");
            _db = _client.GetDatabase("Clip");
            _clips = _db.GetCollection<Clip>("Clips");
        }

        public Clip AddClip(Clip item)
        {
            _clips.InsertOne(item);
            return item;
        }

        public IEnumerable<Clip> GetAllBananas()
        {
            return _clips.Find(c => true).ToList();
        }

        public Clip GetClip(Guid id)
        {
            return _clips.Find(c => c.Id == id).Single();
        }

        public bool RemoveBanana(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateClip(string id, Clip item)
        {
            throw new System.NotImplementedException();
        }
    }
}