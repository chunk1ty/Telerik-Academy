namespace MobileInformation
{
    using System;
    class OnlyMain
    {
        static void Main()
        {
            Display display = new Display(5, 16000000);
            Battery battery = new Battery("samsung", 68, 25, BatteryType.NiCd);
            GSM phone = new GSM("S4", "Samsung", 650, "Andriyan", battery, display);
           
            phone.AddCall(new Call(DateTime.Now, "0899 99 999", 5));
            phone.AddCall(new Call(DateTime.Now, "03333333333", 2));
            phone.AddCall(new Call(DateTime.Now, "02222222222", 3));
            phone.AddCall(new Call(DateTime.Now, "08877777777", 1));

            //for (int i = 0; i < phone.CallHistory.Count; i++)
            //{
            //    Console.WriteLine(phone.CallHistory[i]);
            //}
            //Console.WriteLine("After removing");
            //phone.RemoveCall(1);
            //for (int i = 0; i < phone.CallHistory.Count; i++)
            //{
            //    Console.WriteLine(phone.CallHistory[i]);
            //}
            //Console.WriteLine("After clear history");
            //phone.ClearCalls();
            //for (int i = 0; i < phone.CallHistory.Count; i++)
            //{
            //    Console.WriteLine(phone.CallHistory[i]);
            //}

            decimal result =  phone.CalculatePrice(17.2M);
            Console.WriteLine(result);
        }
    }
}
