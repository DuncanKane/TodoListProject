using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListData.Repository
{
    class TodoListData<T> : ITodoListData<T>
    {
        public void Add(T todoList)
        {
            throw new NotImplementedException();
        }

        public void Delete(T todoList)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T todoList)
        {
            throw new NotImplementedException();
        }
    }
}
