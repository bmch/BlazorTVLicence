﻿using MongoDB.Bson.Serialization.Attributes;

namespace Notes.Core
{
    public class Note
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
