namespace LINQTest;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<ProductModel> products = new List<ProductModel>
        {
            new ProductModel
            {
                id = 0,
                name = "iPhone 12 Mini",
                cost = 100
            },
            new ProductModel
            {
                id = 1,
                name = "iPhone 14 Pro",
                cost = 400
            },
            new ProductModel
            {
                id = 2,
                name = "iPhone 13 Max",
                cost = 250
            },
        };
        /*
        List<string> searchHits = new List<string> { };
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].cost > 50)
            {
                searchHits.Add(products[i].name);
            }
            
        }

        foreach(string productName in searchHits)
        {
            Console.WriteLine(productName);
        }
        Console.ReadLine();
        */

        var searchHits =
            from product in products
            where (product.cost > 200)
            select product.name;

        Console.WriteLine(searchHits);
        foreach (var hit in searchHits)
        {
            Console.WriteLine(hit);
        }
        Console.WriteLine();
        products[1].name = "Samsung 19";

        foreach (var hit in searchHits)
        {
            Console.WriteLine(hit);
        }

        products[1].name = "Used iPhone 14 Pro";
        products[1].cost = 50;
        Console.WriteLine();
        foreach (var hit in searchHits)
        {
            Console.WriteLine(hit);
        }
    }
}

