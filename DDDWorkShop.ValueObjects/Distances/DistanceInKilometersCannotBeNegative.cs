using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.Distances
{
    [Serializable]
    internal class DistanceInKilometersCannotBeNegative : Exception
    {
        public DistanceInKilometersCannotBeNegative()
        {
        }

        public DistanceInKilometersCannotBeNegative(string? message) : base(message)
        {
        }

        public DistanceInKilometersCannotBeNegative(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DistanceInKilometersCannotBeNegative(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}