using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp.Components.Data
{
    public class TodoItem
    {
        public bool isDone {  get; set; } = false;
        public string? title { get; set; }
    }
}
