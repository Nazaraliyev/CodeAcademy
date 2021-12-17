using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Product
    {
        public string Name;
        public int Id;
        public int Count;
        public double Price;
        public string Valuta;
        public double TotalIncome;

        public Product(string name)
        {
            this.Name = name;
        }
    }
}
