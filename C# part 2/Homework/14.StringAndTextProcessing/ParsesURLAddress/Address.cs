using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace ParsesURLAddress
{
    class Address
    {
        static void Main()
        {
            string input = @"http://regexhero.net/tester/?action=restart";

            //my solution
            //int index = input.IndexOf(':');
            //string protocol = input.Substring(0, index);

            //int startIndex = input.IndexOf('/') + 2;
            //int endIndex = input.IndexOf('/',startIndex);
            //string server = input.Substring(startIndex, endIndex - startIndex);

            //string resourse = input.Substring(endIndex, input.Length - endIndex);

            //Console.WriteLine("[protocol] = {0}",protocol);
            //Console.WriteLine("[server] = {0}", server);
            //Console.WriteLine("[resource] = {0}", resourse);

            //S gotov klas
            //Uri uri = new Uri("http://www.devbg.org/forum/index.php");
            //Console.WriteLine(uri.Scheme);
            //Console.WriteLine(uri.Host);
            //Console.WriteLine(uri.AbsolutePath);

            //Regex
            Match protocol = Regex.Match(input, @"\b\w+");
            Console.WriteLine("[protocol] = \"{0}\"", protocol);

            Match server = Regex.Match(input, @"//(\w+.\w+)");
            Console.WriteLine("[server] = \"{0}\"", server);

            Match resource = Regex.Match(input, @"\b/\S+");
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
