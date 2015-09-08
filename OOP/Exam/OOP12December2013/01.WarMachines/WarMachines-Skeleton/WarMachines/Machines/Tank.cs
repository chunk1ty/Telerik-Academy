namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;
    class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPOints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefencePointsModifier = 30;

        public Tank(string initialName, double initialAttackPoints, double initialDefencePoints)
            : base(initialName, InitialHealthPOints, initialAttackPoints, initialDefencePoints)
        {
            this.ToggleDefenseMode();   
        }
        public bool DefenseMode { get; private set; }        

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefencePointsModifier;
                   
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefencePointsModifier;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            string defenceModeAsString = this.DefenseMode ? "ON" : "OFF";
            result.Append(string.Format(" *Defense: {0}", defenceModeAsString));

            return result.ToString();
        }
    }
}
