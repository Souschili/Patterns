using Specification.Core;

namespace Specification.GoodVariant
{
    //наследуемся от фильтра
    internal class ProductFilterNew : IFilter<Product>
    {
        
        public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> specification)
        {
            foreach (var item in items)
            {
                if(specification.IsSatisfy(item))
                    yield return item;
            }
        }
    }
}
