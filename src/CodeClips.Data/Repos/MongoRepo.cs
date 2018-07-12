using CodeClips.Entities.Clips;
using MongoDB.Bson;
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

        public Clip AddClip(Clip clip)
        {
            _clips.InsertOne(clip);

            return clip;
        }

        public IEnumerable<Clip> GetAllClips()
        {
            return _clips.Find(c => true).ToList();
        }

        public Clip GetClip(Guid id)
        {
            return _clips.Find(c => c.Id == id).Single();
        }

        public bool RemoveClip(Guid id)
        {
            DeleteResult del = _clips.DeleteOne(c => c.Id == id);
            
            return del.DeletedCount == 1;
        }

        public bool UpdateClip(Guid id, Clip clip)
        {
            UpdateResult up = _clips.UpdateOne(Builders<Clip>.Filter.Eq("Id", id), Builders<Clip>.Update.Set("Title", clip.Title));
            
            return up.ModifiedCount == 1;
        }
    }
}