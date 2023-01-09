namespace Sorting;
using Products;
using ProductMGRS;

public class ProductSorting : IComparer<Product>
{
    public int Compare(Product p1, Product p2)
    {
        if (p1.Price > p2.Price)
            return 1;
        else if (p1.Price < p2.Price)
            return -1;
        else
            return 0;
    }
}
