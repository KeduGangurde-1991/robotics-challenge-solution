using System;

///class for the custom exception to handle impossible allocation scenarios
namespace RoboticsChallenge.Exceptions
{
    public class ImpossibleAllocationException : Exception
    {
        public ImpossibleAllocationException()
            : base("It is impossible to fulfill the requested hours with the available robots.") { }

        public ImpossibleAllocationException(string message)
            : base(message) { }
    }
}
