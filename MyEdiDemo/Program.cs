using System;
using System.Linq;
using MyEdiDemo.connection;
using MyEdiDemo.models;

namespace MyEdiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                try
                {
                    var desserts = db.Desserts.ToList(); // 查全部

                    Console.WriteLine($"✅ 連線成功！共找到 {desserts.Count} 筆 Dessert 資料：");

                    foreach (var dessert in desserts)
                    {
                        Console.WriteLine($"ID: {dessert.DessertId}, Name: {dessert.DessertName}, Price: {dessert.DessertPrice}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ 連線失敗！錯誤訊息: {ex.Message}");
                }
            }
        }
    }
}

