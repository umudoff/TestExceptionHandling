using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverter
{
    [Serializable]
    public class NonDigitException : Exception
    {
  
       public string EnteredValue { get; set; }
        public NonDigitException() { }
        public NonDigitException(string message): base(message) { }
       public NonDigitException(string message, string enteredValue) : base(message)
        {
            EnteredValue = enteredValue;
        }


    }
}





