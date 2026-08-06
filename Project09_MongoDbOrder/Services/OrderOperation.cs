using MongoDB.Bson;
using Project09_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project09_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        { 
            var connection = new MongoDbConnection();
            var ordersCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {
                {"CustomerName", order.CustomerName},
                {"District", order.District},
                {"City", order.City},
                {"TotalPrice", order.TotalPrice}
            };

            ordersCollection.InsertOne(document);
        }
    }
}
