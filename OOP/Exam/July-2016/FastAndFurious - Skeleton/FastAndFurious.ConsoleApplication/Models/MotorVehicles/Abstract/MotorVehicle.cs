namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    using Common.Utils;
    using FastAndFurious.ConsoleApplication.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class MotorVehicle : Identifiable, IMotorVehicle, IWeightable, IValuable
    {
        private int weight;
        private int acceleration;
        private int topSpeed;
        private decimal price;
        private ICollection<ITunningPart> tunningParts;

        public MotorVehicle(decimal price, int weight, int topSpeed, int acceleration)
        {           
            this.weight = weight;
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
            this.price = price;
            this.tunningParts = new HashSet<ITunningPart>();
        }

        public decimal Price
        {
            get
            {
                return this.Price + this.TunningParts.Sum(x => x.Price);
            }
        }
        public int Weight
        {
            get
            {
                return this.weight + this.TunningParts.Sum(x => x.Weight);
            }
        }
        public int Acceleration
        {
            get
            {
                return this.acceleration + this.TunningParts.Sum(x => x.Acceleration);
            }
        }
        public int TopSpeed
        {
            get
            {
                return this.topSpeed + this.TunningParts.Sum(x => x.TopSpeed);
            }
        }
        public IEnumerable<ITunningPart> TunningParts
        {
            get
            {
                return this.tunningParts;
            }
        }

        public void AddTunning(ITunningPart part)
        {
            if (part == null)
            {
                throw new ArgumentException();
            }

            this.tunningParts.Add(part);
        }

        // Magic
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            var topSpeedInMetersPerSecond = MetricUnitsConverter.GetMetersPerSecondFrom(this.TopSpeed);
            var accelerationInMetersPerSecondSquared = this.Acceleration;

            var timeRequiredToReachTopSpeedInSeconds = (topSpeedInMetersPerSecond / accelerationInMetersPerSecondSquared);
            var distanceTravelledWhileReachingTopSpeedInMeters = accelerationInMetersPerSecondSquared * Math.Pow(timeRequiredToReachTopSpeedInSeconds, 2);

            if (trackLengthInMeters == distanceTravelledWhileReachingTopSpeedInMeters)
            {
                return TimeSpan.FromSeconds(timeRequiredToReachTopSpeedInSeconds);
            }
            else if (trackLengthInMeters > distanceTravelledWhileReachingTopSpeedInMeters)
            {
                var remainingDistanceInMeters = trackLengthInMeters - distanceTravelledWhileReachingTopSpeedInMeters;
                var timeRequiredToTravelRemainingDistanceInSeconds = remainingDistanceInMeters / topSpeedInMetersPerSecond;
                var totalTimeInSeconds = timeRequiredToReachTopSpeedInSeconds + timeRequiredToTravelRemainingDistanceInSeconds;

                return TimeSpan.FromSeconds(totalTimeInSeconds);
            }
            else
            {
                var totalTime = Math.Sqrt((trackLengthInMeters / accelerationInMetersPerSecondSquared));

                return TimeSpan.FromSeconds(totalTime);
            }
        }

        public bool RemoveTunning(ITunningPart part)
        {
            if (part == null)
            {
                throw new ArgumentException();
            }

            return this.tunningParts.Remove(part);
        }
    }
}
