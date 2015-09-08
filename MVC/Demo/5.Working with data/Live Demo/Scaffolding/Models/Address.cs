using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Scaffolding.Models
{
    [ComplexType]
    public class Address
    {
        public string Town { get; set; }

        public string Country { get; set; }
    }
}
