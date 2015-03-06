using System;
namespace Profiler
{
    public class UserProfile
    {
        [Save]
        public string FirstName { get; set; }

        [Save]
        public string LastName { get; set; }

        [Save]
        public int Age { get; set; }
    }
}
