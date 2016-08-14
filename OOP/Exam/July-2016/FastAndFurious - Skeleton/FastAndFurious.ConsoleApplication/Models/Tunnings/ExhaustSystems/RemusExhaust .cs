namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using Abstract;
    using Common.Enums;

    public class RemusExhaust : Exhaust
    {
        public RemusExhaust() : base(679M, 11500, 8, 32, TunningGradeType.MidGrade, ExhaustType.StainlessSteel)
        {
        }
    }
}
