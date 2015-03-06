using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadFileFromInternet
{
    class DownloadFile
    {
        static void Main()
        {
            WebClient client = new WebClient();
            using (client)
            {
                try
                {
                    Console.WriteLine("This program will download the logo of BARS to your desktop.");
                    //adress at internet
                    //string url = "http://www.devbg.org/img/Logo-BASD.jpg";
                    string url = "http://freewallpic.com/wp-content/uploads/2013/12/Concept-TRON-Car-Wallpaper.jpg";
                    //to take name of the wallpaper
                    string fileName = Path.GetFileName(url);
                    //to save wallpaper with it's real name 
                    string name = string.Format(@"%UserProfile%\Desktop\{0}.jpg", fileName);
                    //path where i want to download (in this case on the Desktop)
                    string path = Environment.ExpandEnvironmentVariables(name);    
                    
                    client.DownloadFile(url,path);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You entered an empty address.");
                }
                catch (WebException we)
                {
                    Console.WriteLine(we.Message);
                }
                catch (NotSupportedException nse)
                {
                    Console.WriteLine(nse.Message);
                }
                finally
                {
                    Console.WriteLine("Download is done!");
                }
            }
        }
    }
}
