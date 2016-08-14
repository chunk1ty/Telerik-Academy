namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using Abstract;
    using Common.Enums;

    public class MagnaflowExhaust : Exhaust
    {
        public MagnaflowExhaust() : base(379M, 12800, 5, 25, TunningGradeType.LowGrade, ExhaustType.NickelChromePlated)
        {
        }
    }
}
