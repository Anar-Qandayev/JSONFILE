using Newtonsoft.Json;
using JsOn.Models;
using System;
using System.Collections.Generic;
using System.IO;
namespace JsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product toysCar = new Product { Id = 1, Name = "MigMig", Price = 6.50 };
            //Product toysBus = new Product { Id = 2, Name = "Halley", Price = 10.50 };
            //Product toysDoll = new Product { Id = 3, Name = "Polesie", Price = 12.70 };
            //OrderItem item1 = new OrderItem { Id = 1, Product = toysCar, Count = 1, TotalPrice = toysCar.Price * 1 };
            //OrderItem item2 = new OrderItem { Id = 2, Product = toysBus, Count = 2, TotalPrice = toysBus.Price * 2 };
            //OrderItem item3 = new OrderItem { Id = 3, Product = toysDoll, Count = 4, TotalPrice = toysDoll.Price * 4 };
            //OrderItem item4 = new OrderItem { Id = 4, Product = toysBus, Count = 1, TotalPrice = toysBus.Price * 1 };
            //List<OrderItem> orderItems1 = new List<OrderItem>();
            //orderItems1.Add(item1);
            //orderItems1.Add(item3);
            //List<OrderItem> orderItems2 = new List<OrderItem>();
            //orderItems2.Add(item2);
            //orderItems2.Add(item4);
            //Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            //Order order2 = new Order { Id = 2, OrderItems = orderItems2 };
            //var jsonObj = JsonConvert.SerializeObject(order1);
            //Console.WriteLine(jsonObj);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\tu7bxfga8\Desktop\New folder\JSONFILE\JsOn\File\json1.json"))
            //{
            //    sw.WriteLine(jsonObj);
            //}
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\tu7bxfga8\Desktop\New folder\JSONFILE\JsOn\File\json2.json"))
            {
                result = sr.ReadToEnd();
            }
            Order o1 = JsonConvert.DeserializeObject<Order>(result);
            Console.WriteLine(o1.OrderItems[0].Product.Name);
        }
    }
}
