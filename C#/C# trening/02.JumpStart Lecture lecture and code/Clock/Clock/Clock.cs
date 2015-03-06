using System;
using System.Text;

class Clock
{
    static void Main()
    {
        Console.OutputEncoding= Encoding.UTF8;
        //int hour = 0;
        //int minute = 0;
        //string time=null;

        //while (true)
        //{
        //    Console.WriteLine("Въведете час във формат чч:мм ");
        //    string timeString = Console.ReadLine();

        //    string[] elements = timeString.Split(':');                          //razdelqme stringa na elementi t.e ako vuvedem 11:22
        //                                                            // element[0]=11 , element[1]=22 zashtoto izpolzavame  Split(':') 
        //    if (elements.Length != 2)
        //    {
        //        continue;   
        //    }
        //    //if (elements[0].Length != 2 || elements[1].Length != 2)
        //    //{
        //    //    continue;
        //    //}
        //    hour = int.Parse(elements[0]);                            
        //    minute = int.Parse(elements[1]);       
        //    if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
        //    {
        //        continue;   
        //    }
        //    break;
        //}
        while (true)
        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;

            string hourString = ConvertTimeToString(currentTime.Hour, true);
            string minuteString = ConvertTimeToString(currentTime.Minute, false);
            string secondString = ConvertTimeToString(currentTime.Second, false);

            if (currentTime.Minute > 0)
            {
                Console.WriteLine(hourString + " часа " + "и " + minuteString + (currentTime.Minute == 1 ? " минутa" : " минути") + " и "+
                    secondString + (currentTime.Second == 1 ? " секунда" : " секунди"));
            }
            else
            {
                Console.WriteLine(hourString + " часа" );
            }
            System.Threading.Thread.Sleep(200);
        }
    }

    private static string ConvertTimeToString(int unit,bool isHour)
    {
        string time = "";
        int ones = unit % 10;
        int tens = unit / 10;

        string hourOneString = ConvertDigitToString(ones, isHour);
        string hourTensString = ConvertDigitToString(tens, isHour);

        if (tens == 0)
        {
            time += hourOneString;
        }
        else if (tens == 1)
        {
            if (ones==0)
            {
                ;
            }
            else if (ones == 1)
            {
                time += hourOneString + "a";
            }
            else
            {
                time += hourOneString + "на";
            }

            time += "десет";
        }
        else
        {
            if (ones == 0)
            {
                time += hourTensString + "десет";
            }
            else
            {
                time += hourTensString + "десет и " + hourOneString;
            }
        }
        
        return time;
    }

    private static string ConvertDigitToString(int digit,bool isHour)
    {
        switch (digit)
        {
            case 0: return "нула";
            case 1: return isHour ? "един" : "една";
            case 2: return isHour ? "два" : "две";
            case 3: return "три";
            case 4: return "четири";
            case 5: return "пет";
            case 6: return "шест";
            case 7: return "седем";
            case 8: return "осем";
            case 9: return "девет";
            default: return "";       
        }
    }
}
