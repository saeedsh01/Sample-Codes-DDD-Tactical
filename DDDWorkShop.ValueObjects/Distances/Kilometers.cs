namespace DDDWorkShop.ValueObjects.Distances
{
    public class Kilometers
    {
        protected decimal DistanceInKilometers { get; private set; }

        public Kilometers(decimal distanceInKilometers)
        {
            if (distanceInKilometers < (decimal)0.0)
                throw new DistanceInKilometersCannotBeNegative();
            this.DistanceInKilometers = distanceInKilometers;
        }
    }
}