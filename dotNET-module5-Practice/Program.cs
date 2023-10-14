using System;
using System.Collections.Generic;

namespace Module5Practice
{
    public class Module5Practice
    {
        static void Main(string[] args)
        {
            try
            {
                CallMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
        }

        static void CallMethod()
        {
            try
            {
                AnotherMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Exception handled in CallMethod.");
                throw;
            }
        }

        static void AnotherMethod()
        {
            throw new CustomException("Custom Exception thrown from AnotherMethod.");
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
