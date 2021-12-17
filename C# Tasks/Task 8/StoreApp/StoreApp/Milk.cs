using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Milk : Product
    {
        public Milk(string name) : base(name)
        {
            this.Name = name;
        }
        public double Volume;
        public double FatRate;
    }
}
