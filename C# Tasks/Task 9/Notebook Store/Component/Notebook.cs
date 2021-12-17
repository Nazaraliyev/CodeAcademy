using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Component
{
    class Notebook : Product
    {
        public int Ram;
        public int Storage;
        public string Brand;
        public string Model;

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand : {Brand}   model : {Model}    Name : {Name}   Ram : {Ram}    Storage : {Storage}");
        }
    }
}
