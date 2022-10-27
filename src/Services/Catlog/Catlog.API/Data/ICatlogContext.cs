using Catlog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catlog.API.Data
{
    public interface ICatlogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
