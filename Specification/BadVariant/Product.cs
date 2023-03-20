using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Core
{
    internal class Product
    {
        public readonly string Name;
        public readonly Color Color;
        public readonly Size Size;

        public Product(string name,Color color,Size size)
        {
            Name=name;
            Color=color;
            Size=size;
        }



    }
}
