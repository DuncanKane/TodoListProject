using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListData.Context;
using TodoListData.Entities;

namespace TodoListData.Repository
{
    public class TodoListData<T> : ITodoListData<T>
    {
        public TodoListContext _db;

        public TodoListData(TodoListContext db)
        {
            _db = db;
        }
        public void Add(T todoList)
        {
            _db.Set<TodoListContext>().Add(todoList);
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
