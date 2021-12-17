using Store.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Interfaces
{
    interface IMarket
    {
        public abstract void AddNotebook(Notebook newNB);
        public abstract bool GetNotebook();

    }
}
