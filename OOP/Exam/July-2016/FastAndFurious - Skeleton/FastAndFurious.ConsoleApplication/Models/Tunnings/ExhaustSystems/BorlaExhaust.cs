namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using Abstract;
    using Common.Enums;

    public class BorlaExhaust : Exhaust
    {
        public BorlaExhaust() : base(1299M, 14600, 12, 40, TunningGradeType.HighGrade, ExhaustType.CeramicCoated)
        {
        }
    }
}
