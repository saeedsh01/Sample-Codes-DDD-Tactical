using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.Distances
{

    public class Meters
    {
        protected decimal DistanceInMeters { get; private set; }

        public Meters(decimal distanceInMeters)
        {
            if (distanceInMeters < (decimal)0.0)
                throw new DistancesInMetersCannotBeNegative();
            this.DistanceInMeters = distanceInMeters;
        }       
        public Yards ToYards()
        {
            return new Yards(DistanceInMeters * (decimal)1.0936133);
        }
        public Kilometers ToKilometers()
        {
            return new Kilometers(DistanceInMeters / 1000);
        }
        public Meters Add(Meters meter)
        {
            if (meter.DistanceInMeters<(decimal)0.0)
            {
                throw new DistanceInKilometersCannotBeNegative();
            }
            //DistanceInMeters = DistanceInMeters + meter.DistanceInMeters;
            return new Meters(this.DistanceInMeters + meter.DistanceInMeters);
        }
        public bool IsLongerThan(Meters meter)
        {
            return this.DistanceInMeters > meter.DistanceInMeters;
        }

        public bool Equals(object obj) {
            var m=obj as Meters;
            if (m == null) return false;
            return this.DistanceInMeters == m.DistanceInMeters;
        }
        public int GetHashCode()
        {
            return -177055885 + DistanceInMeters.GetHashCode();
        }
    }
}
