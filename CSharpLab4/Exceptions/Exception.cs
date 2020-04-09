using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab4.Exceptions
{
    class BornInFutureException : ArgumentException
    {
        public DateTime Value { get; }
        public BornInFutureException(string message, DateTime val)
        : base(message)
        {
            Value = val;
        }
    }
    class IncorrectEmailException : ArgumentException
    {
        public string Value { get; }
        public IncorrectEmailException(string message, string val): base(message)
        {
            Value = val;
        }
    }
    class IncorrectBirthDateException : ArgumentException
    {
        public DateTime Value { get; }
        public IncorrectBirthDateException(string message, DateTime val) : base(message)
        {
            Value = val;
        }
    }
}