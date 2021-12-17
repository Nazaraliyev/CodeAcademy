using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Interfaces
{
    interface IContact<T>
    {
        public void NewContact(T Contact);
        public void UpdateContact(int id, T UpdatedContact);
        public void DeleteContact(int id);
        public T FindContact (int id);
        public bool ReadAll();
    }
}
