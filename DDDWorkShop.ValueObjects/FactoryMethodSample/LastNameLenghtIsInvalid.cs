using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class LastNameLenghtIsInvalid : Exception
    {
        public LastNameLenghtIsInvalid()
        {
        }

        public LastNameLenghtIsInvalid(string? message) : base(message)
        {
        }

        public LastNameLenghtIsInvalid(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LastNameLenghtIsInvalid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}