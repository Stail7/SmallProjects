using System;

namespace Generics 
{
    //// CONSTRAINS
    // where T : IComparable (is an interface)
    // where T : Product (is of type Product or inherits from Product class)
    // where T : class (is a reference type)
    // where T : struct (is a value type)
    // where T : new() (is an object with default constructor)

    //// where T : IComparable (is an interface)
    public class ConstrainsOnGenerics<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 1 ? a : b;
        }
    }

    //// where T : Product (is of type Product or inherits from Product class)
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public double CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    //// where T : struct (is a value type)
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public Nullable() { }

        public Nullable (T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; } // returns TRUE if object is NOT null
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T); // returns default value of a type
        }
    }

    //// where T : new() (is an object with default constructor)
    public class Utility<T> where T : IComparable, new()
    {
        private void GetType(T value)
        {
            var obj = new T();
        }
    }
}