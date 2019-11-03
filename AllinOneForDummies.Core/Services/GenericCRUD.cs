using AllinOneForDummies.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllinOneForDummies.Core.Services
{
    //ToDo zobaczyć co się stanie z 'where' i bez niego
    public class GenericCRUD<T> : IGenericCRUD<T>
    {
        private readonly DummiesContext _context;

        public GenericCRUD(DummiesContext context)
        {
            _context = context;
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            var type = typeof(T);

            throw new NotImplementedException();
        }
    }
}
