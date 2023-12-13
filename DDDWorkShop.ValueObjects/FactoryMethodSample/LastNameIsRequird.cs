using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class LastNameIsRequird : Exception
    {
        public LastNameIsRequird()
        {
        }

        public LastNameIsRequird(string? message) : base(message)
        {
        }

        public LastNameIsRequird(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LastNameIsRequird(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}