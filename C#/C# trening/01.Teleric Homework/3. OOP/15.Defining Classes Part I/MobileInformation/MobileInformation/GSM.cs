namespace MobileInformation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();
        private static GSM iphone4s = new GSM("IPhone 4S", "Iphone");
        private List<Call> callHistory = new List<Call>();

        //Properties
        public string Model 
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public int Price 
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner 
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }        
        public static GSM Iphone4s
        {
            get
            {
                return GSM.iphone4s;

            }
        } //TODO : implement whole information for static object
        public List<Call> CallHistory 
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        //Constructor
        public GSM(string gsmModel,string gsmManufacturer)
        {
            this.Model = gsmModel;
            this.Manufacturer = gsmManufacturer;
        }
        public GSM(string gsmModel,string gsmManufacturer,int gsmPrice,string gsmOwner,Battery gsmBattery,Display gsmDisplay)
            :this(gsmModel,gsmManufacturer)
        {
            this.Price = gsmPrice;
            this.Owner = gsmOwner;
            this.Battery = gsmBattery;
            this.Display = gsmDisplay;
        }

        //Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

          
            sb.Append("\nModel : " + this.Model);           
            sb.Append("\nManufacturer : " + this.Manufacturer);
            
            if (this.Price == 0)
            {
                sb.Append("\nPrice : " + "N/A");
            }
            else
            {
                sb.Append("\nPrice : " + this.Price);
            }
            if (this.Owner ==null)
            {
                sb.Append("\nOwner : " + "N/A");
            }
            else
            {
                sb.Append("\nOwner : " + this.Owner);
            }
            if (this.Battery.Model == null)
            {
                sb.Append("\nBattery Model : " + "N/A");
            }
            else
            {
                sb.Append("\nBattery Model : " + this.Battery.Model);
            }
            if (this.Battery.HoursIdle == 0)
            {
                sb.Append("\nBattery hours idle : " + "N/A");
            }
            else
            {
                sb.Append("\nBattery hours idle : " + this.Battery.HoursIdle);
            }
            if (this.Battery.HoursTalk == 0)
            {
                sb.Append("\nBattery hours talk : " + "N/A"); 
            }
            else
            {
                sb.Append("\nBattery hours talk : " + this.Battery.HoursTalk);
            }
            if (this.Battery.Type == 0 )
            {
                sb.Append("\nBattery type : " + "N/A");
            }
            else
            {
                sb.Append("\nBattery type : " + this.Battery.Type);
            }
            if (this.Display.NumberOfColors == 0)
            {
                sb.Append("\nNumbers of colors : " + "N/A");
            }
            else
            {
                sb.Append("\nNumbers of colors : " + this.Display.NumberOfColors);
            }
            if (this.Display.Size == 0)
            {
                sb.Append("\nDisplay size : " + "N/A");
            }
            else
            {
                sb.Append("\nDisplay size : " + this.Display.Size);
            }

            return sb.ToString();
        }        
        public void AddCall (Call call)
        {
            this.CallHistory.Add(call);
        }
        public void RemoveCall (int index)
        {
            this.CallHistory.RemoveAt(index);
        }
        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }
        public decimal CalculatePrice(decimal pricePerMinute)
        {
            decimal durationsum = 0;
            foreach (var item in CallHistory)
            {
                durationsum += item.Duration;
            }
            durationsum = (durationsum / 60) * pricePerMinute;
            return durationsum;
        }
    }
}
