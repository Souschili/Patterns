using Specification.Core;

namespace Specification.GoodVariant
{
    // in this case we can overload operator 
    internal abstract class Specification<T>
    {
        public abstract bool IsSatisfy(T item);

        // overide operator
        public static Specification<T> operator &(Specification<T> first,Specification<T> second)
        {
            return new AndSpecification<T>(first,second);
        }
    }

    // by color
    class ColorSpecification : Specification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public override bool IsSatisfy(Product item)
        {
            return item.Color == _color;
        }
    }

    // by size
    class SizeSpecification:Specification<Product>
    {
        private Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public override bool IsSatisfy(Product item)
        {
            return item.Size== _size;
        }
    }
}