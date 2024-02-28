using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TodoItem> Items { get; set; }
    }
}
