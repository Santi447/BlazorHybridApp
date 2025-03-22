using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author:Santiago Pabon Date: 2025 - 03- 22. This is the custom exception class that allows
// for a InvalidSpecialCharacterInput to be executed.




namespace BlazorHybridApp.Components.Exceptions
{
    internal class InvalidSpecialCharacterInput : Exception
    {
        public InvalidSpecialCharacterInput(string errorMessage) : base(errorMessage)
        {
        }
    }
}
