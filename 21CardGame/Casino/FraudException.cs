using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    // Define a custom exception class called FraudException that inherits from the base Exception class.
    public class FraudException : Exception
    {
        // Default constructor for FraudException.
        // It calls the base class (Exception) constructor with no arguments.
        public FraudException()
            : base() { }

        // Constructor for FraudException that takes a string message as a parameter.
        // It calls the base class (Exception) constructor with the message argument.
        public FraudException(String message)
            : base(message) { }
    }

}
