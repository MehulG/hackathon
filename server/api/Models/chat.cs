using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class chat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
    }
}
