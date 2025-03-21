using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp.Components.Exceptions
{
    internal class InvalidSpecialCharacterInput : Exception
    {
        public InvalidSpecialCharacterInput(string errorMessage) : base(errorMessage)
        {
        }
    }
}
