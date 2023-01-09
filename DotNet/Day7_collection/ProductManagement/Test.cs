using ProductMGRS;
using Products;
using System.Collections.Generic;
using Sorting;

ProductMGR p1 = new ProductMGR();

List<Product> products = new List<Product>();
products = p1.sampleData();
Console.WriteLine("Before  Sorting ");
foreach (Product p in products)
{
    Console.WriteLine(p);
}
products.Sort();
Console.WriteLine("After Sorting by ID");
foreach (Product p in products)
{
    Console.WriteLine(p);
}
ProductSorting sortPrice = new ProductSorting();
products.Sort(sortPrice);
Console.WriteLine("After Sorting by Price");
foreach (Product p in products)
{
    Console.WriteLine(p);
}
