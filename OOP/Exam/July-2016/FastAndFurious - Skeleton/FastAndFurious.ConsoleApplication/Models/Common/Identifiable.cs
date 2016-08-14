namespace FastAndFurious.ConsoleApplication.Models
{
    using Common.Utils;
    using FastAndFurious.ConsoleApplication.Contracts;

    public class Identifiable : IIdentifiable
    {
        private readonly int id;

        public Identifiable()
        {
            this.id = DataGenerator.GenerateId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
