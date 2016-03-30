using System;

namespace PtaSync
{
    public class EaAutomationException : Exception
    {
        public EaAutomationException()
        {
        }

        public EaAutomationException(string message)
            : base(message)
        {
        }

        public EaAutomationException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
