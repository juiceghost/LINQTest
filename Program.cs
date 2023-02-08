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
                name = "Used iPhone 13 Max",
                cost = 250
            },
            new ProductModel
            {
                id = 3,
                name = "iPhone 13",
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

        //var queryCustomersByCity =
        //from cust in customers
        //group cust by cust.City;

        // customerGroup is an IGrouping<string, Customer>
        //foreach (var customerGroup in queryCustomersByCity)
        //{
        //    Console.WriteLine(customerGroup.Key);
        //    foreach (Customer customer in customerGroup)
        //    {
        //        Console.WriteLine("    {0}", customer.Name);
        //    }
        //}

        //var student1 = objStudent.GroupBy(x => x.Location);

        "aardvarks  AND  antelopes AND hippopotami"
                .Replace("antelopes", "centipedes")
                .Substring("aardvarks".Length)
                .ToLower()
                .Trim()
                .Split(new[] { "and" }, StringSplitOptions.None)
                .ToList()
                .ForEach(item => Console.WriteLine(item.Trim()));
        Console.ReadLine();

        var oldSearchHits =
            from product in products
            group product by product.cost;
        //where (product.cost > 200)
        //select product.name;

        var searchHits = products.GroupBy(product => product.cost);

        Console.WriteLine(searchHits);
        Console.WriteLine("First query");
        foreach (var productGroup in searchHits)
        {
            Console.WriteLine(productGroup.Key);
            foreach (ProductModel product in productGroup)
            {
                Console.WriteLine("    {0}", product.name);
            }
        }
        Console.WriteLine();
        /*
        products[1].name = "Samsung 19";
        Console.WriteLine("Changed single product name");
        foreach (var hit in searchHits)
        {
            Console.WriteLine(hit);
        }

        products[1].name = "Used iPhone 14 Pro";
        products[1].cost = 50;
        Console.WriteLine();
        Console.WriteLine("Changed name and cost");
        foreach (var hit in searchHits)
        {
            Console.WriteLine(hit);
        }
        products[1].cost = 250;
        List<string> productNames =
            (from product in products
            where (product.cost > 200)
            select product.name).ToList();

        Console.WriteLine();
        Console.WriteLine("Cached results");
        foreach (string name in productNames)
        {
            Console.WriteLine(name);
        }
        products[1].name = "Used iPhone SE";

        Console.WriteLine();
        Console.WriteLine("Cached results #2(changed name)");
        foreach (string name in productNames)
        {
            Console.WriteLine(name);
        }
        */

    }
}

