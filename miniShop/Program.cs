
using Newtonsoft.Json;
using System.IO;




using miniShop;

class Program
{
    static void Main(string[] args)
    {

        var Products = new List<Product>();

        Products.Add(new Product("Milk", "Dairy", 100, 1));
        Products.Add(new Product("Yogurt", "Dairy", 50, 10));
        Products.Add(new Product("Loaf", "Bread", 30, 40));



        Console.WriteLine("Какой продукт выберите?: ");
        string Name = Console.ReadLine();


        var findProduct = Products.Where(product => product.Name == Name);
       

        foreach(var item in findProduct)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Category:{item.Category}, Quntity: {item.Quantity}");
        }


        string json = JsonConvert.SerializeObject(Products, Formatting.Indented);
        File.WriteAllText("Products.json", json);
        Console.WriteLine($"File saved:  { Path.GetFullPath("Products.json")}");


    }

    
}