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
                id = 0,
                name = "iPhone 14 Pro",
                cost = 400
            },
            new ProductModel
            {
                id = 0,
                name = "iPhone 13 Max",
                cost = 250
            },
        };

        var subset =
            from product in products
            where (product.cost > 200)
            select product.name;

        Console.WriteLine(products.Count);
        foreach (var hit in subset)
        {
            Console.WriteLine(hit);
        }
    }
}

