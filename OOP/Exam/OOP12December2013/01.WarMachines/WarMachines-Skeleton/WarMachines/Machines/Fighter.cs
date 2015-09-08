namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;
    class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPOints = 200;

        public Fighter(string initialName, double initialAttackPoints, double initialDefencePoints,bool initialStealtMode)
            : base(initialName, InitialHealthPOints, initialAttackPoints, initialDefencePoints)
        {
            this.StealthMode = initialStealtMode;
        }
        public bool StealthMode { get; private set; }        

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            string stealtModeAsString = this.StealthMode ? "ON" : "OFF";
            result.Append(string.Format(" *Stealth: {0}", stealtModeAsString));

            return result.ToString();
        }
    }
}
