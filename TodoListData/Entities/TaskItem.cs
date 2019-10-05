using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListData.Entities
{
    public class TaskItem
    {
        [Key]
        public int ItemId { get; set; }
        [ForeignKey]
        public int Id { get; }
        public ICollection<TodoTask> TodoTask { get; set; }
    }
}
