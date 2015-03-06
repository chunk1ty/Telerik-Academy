namespace MobileInformation
{
    public enum BatteryType
    {
        Li_Ion,NiMH,NiCd
    }
    public class Battery
    {
        //Fields
        private string model;
        private int hoursIndle;
        private int hoursTalk;
        private BatteryType type;

        //Properties
        public string Model 
        { 
            get {return this.model;}
            set { this.model = value;} 
        }
        public int HoursIdle 
        {
            get { return this.hoursIndle; }
            set { this.hoursIndle = value; } 
        }
        public int HoursTalk 
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; } 
        }
        public BatteryType Type
        {
            get { return this.type; }
        }

        //Constructor
        public Battery ()
        {

        }
        public Battery (string batteryModel,int batteryIdle,int batteryTalk,BatteryType typeBattery)
        {
            this.Model = batteryModel;
            this.HoursIdle = batteryIdle;
            this.HoursTalk = batteryTalk;
            this.type = typeBattery;
        }
    }
}
