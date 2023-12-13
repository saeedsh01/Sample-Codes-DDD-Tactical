using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.FactoryMethodSample
{
    [Serializable]
    internal class FirstNameIsRequird : Exception
    {
        public FirstNameIsRequird()
        {
        }

        public FirstNameIsRequird(string? message) : base(message)
        {
        }

        public FirstNameIsRequird(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FirstNameIsRequird(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}