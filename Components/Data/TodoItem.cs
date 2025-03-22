using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:Santiago Pabon Date: 2025 - 03- 22. This is the todoItem class.

namespace BlazorHybridApp.Components.Data
{
    public class TodoItem
    {
        public bool isDone {  get; set; } = false;
        public string? title { get; set; }
    }
}
