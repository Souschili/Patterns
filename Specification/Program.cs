using Specification.Core;
using Specification.GoodVariant;

namespace Specification
{

    internal class Program
    {

        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("tree", Color.Green, Size.Large);
            var house = new Product("house", Color.Blue, Size.Large);
            var products = new Product[] { apple, tree, house };

            var filter = new ProductFilter();
            Console.WriteLine("green items (old)");
            foreach (var item in filter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"- {item.Name} is green ");
            };

            Console.WriteLine("latge product (new) ");
            var bf=new ProductFilterNew();
            var LargeSpec = new SizeSpecification(Size.Large);
           foreach (var e in bf.Filter(products, LargeSpec))
                Console.WriteLine($"- {e.Name} is Large ");

           var ColorandSize=new AndSpecification<Product>(LargeSpec,new ColorSpecification(Color.Blue));
            foreach (var e in bf.Filter(products,ColorandSize))
                Console.WriteLine($"- {e.Name} is Large and Blue ");
        }
    }
}