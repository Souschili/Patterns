namespace Specification.Core
{
    internal class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product product in products)
            {
                if(product.Color == color)
                    yield return product;
            }
        }
    }
}
