using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class FirstNameLenghtIsInvalid : Exception
    {
        public FirstNameLenghtIsInvalid()
        {
        }

        public FirstNameLenghtIsInvalid(string? message) : base(message)
        {
        }

        public FirstNameLenghtIsInvalid(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FirstNameLenghtIsInvalid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}