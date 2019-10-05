﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListData.Repository
{
    interface ITodoListData<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T todoList);
        void Update(T todoList);
        void Delete(T todoList);
    }
}
