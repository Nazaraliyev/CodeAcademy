using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Component
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public abstract void ShowInfo();
    }
}
