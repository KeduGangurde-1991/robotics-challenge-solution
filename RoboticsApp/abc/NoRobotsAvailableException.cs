using System;

///class for the custom exception to handle scenarios where no robots are available for allocation
namespace RoboticsChallenge.Exceptions
{
    public class NoRobotsAvailableException : Exception
    {
        public NoRobotsAvailableException()
            : base("No robots are available for allocation.") { }

        public NoRobotsAvailableException(string message)
            : base(message) { }
    }
}