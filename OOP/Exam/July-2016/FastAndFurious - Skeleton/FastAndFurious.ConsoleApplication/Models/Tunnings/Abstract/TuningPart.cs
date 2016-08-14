namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract
{
    using Common.Enums;
    using Contracts;

    public abstract class TunningPart : Identifiable, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {       
        private readonly int weight;
        private readonly int acceleration;
        private readonly int topSpeed;
        private readonly decimal price;
        private readonly TunningGradeType gradeType;

        public TunningPart(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType) : base()
        {            
            this.weight = weight;
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
            this.price = price;
            this.gradeType = gradeType;
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
        }
        public int Acceleration
        {
            get
            {
                return this.acceleration;
            }
        }
        public int TopSpeed
        {
            get
            {
                return this.topSpeed;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
        }
        public TunningGradeType GradeType
        {
            get
            {
                return this.gradeType;
            }
        }
    }
}
