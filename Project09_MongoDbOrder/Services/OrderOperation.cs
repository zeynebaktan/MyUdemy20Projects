using MongoDB.Bson;
using MongoDB.Driver;
using Project09_MongoDbOrder.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public List<Order> GetAllOrders()
        { 
            var connection = new MongoDbConnection();
            var ordersCollection = connection.GetOrdersCollection();

            var orders = ordersCollection .Find (new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();

            foreach (var order in orders)
            { 
                orderList.Add (new Order
                { 
                   City = order["City"].ToString(),
                   CustomerName = order["CustomerName"].ToString(),
                   District = order["District"].ToString(),
                   OrderId = order["_id"].ToString(),
                   TotalPrice = order["TotalPrice"].AsDecimal
                });
            }
            return orderList;
        }
    }
}
