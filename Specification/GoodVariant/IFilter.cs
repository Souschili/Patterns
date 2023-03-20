namespace Specification.GoodVariant
{
    // интерфейс который фильтрует объекты типа Т
    internal interface IFilter<T>
    {
        IEnumerable<T> Filter(
            IEnumerable<T> items,             // список элементов 
            Specification<T> specification);  // чекер на соответсвие (спецификейшен абсрактный класс) 
    }
}
