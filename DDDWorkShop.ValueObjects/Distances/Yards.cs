namespace DDDWorkShop.ValueObjects.Distances
{
    public class Yards
    {
        protected decimal DistanceInYards {  get; private set; }

        public Yards(decimal distanceInYards)
        {
            if (distanceInYards < (decimal)0.0) {
                throw new DistanceInYardsCannotBeNegative();
            }
            this.DistanceInYards = distanceInYards;
        }
    }
}