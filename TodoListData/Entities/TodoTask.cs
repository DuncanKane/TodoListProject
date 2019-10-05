using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListData.Entities
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public TaskItem TaskItem { get; set; }

    }
}
