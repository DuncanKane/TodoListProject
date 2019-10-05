using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListData.Entities;

namespace TodoListData.Context
{
    public class TodoListContext : DbContext
    {
        public DbSet<TodoTask> TodoTasks { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
