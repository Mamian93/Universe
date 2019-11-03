using System;
using System.Collections.Generic;
using System.Text;

namespace AllinOneForDummies.Core.Interfaces
{
    public interface IGenericCRUD<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
