using System.Runtime.Serialization;

namespace DDDWorkShop.ValueObjects.Distances
{
    [Serializable]
    internal class DistanceInYardsCannotBeNegative : Exception
    {
        public DistanceInYardsCannotBeNegative()
        {
        }

        public DistanceInYardsCannotBeNegative(string? message) : base(message)
        {
        }

        public DistanceInYardsCannotBeNegative(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DistanceInYardsCannotBeNegative(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}