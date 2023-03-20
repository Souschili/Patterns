using Specification.Core;

namespace Specification.GoodVariant
{
    internal class AndSpecification<T>:Specification<T>
    {
        private readonly Specification<T> First,Second;
        public AndSpecification(Specification<T> first,Specification<T> second)
        {
            First = first;
            Second = second;
        }

        public override bool IsSatisfy(T item)
        {
           return First.IsSatisfy(item) && Second.IsSatisfy(item);
        }
    }
}
