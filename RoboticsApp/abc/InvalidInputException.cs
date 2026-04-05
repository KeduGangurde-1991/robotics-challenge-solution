using System;

///class for the custom exception to handle invalid input scenarios
namespace RoboticsChallenge.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException()
            : base("Requested hours must be a positive integer.") { }

        public InvalidInputException(string message)
            : base(message) { }
    }
}
