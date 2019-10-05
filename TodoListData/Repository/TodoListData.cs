using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListData.Context;
using TodoListData.Entities;

namespace TodoListData.Repository
{
    public class TodoListData<T> : ITodoListData<T> where T : class
    {
        public TodoListContext _db;

        public TodoListData(TodoListContext db)
        {
            _db = db;
        }
        public void Add(T todoList)
        {
            _db.Set<T>().Add(todoList);
        }

        public void Delete(T todoList)
        {
            _db.Set<T>().Remove(todoList);
        }

        public T Get(int id)
        {
            var todoList = _db.Set<T>().Find(id);
            return todoList;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Update(T todoList)
        {
            var entry = _db.Entry(todoList);
            entry.State = EntityState.Modified;
        }
    }
}
