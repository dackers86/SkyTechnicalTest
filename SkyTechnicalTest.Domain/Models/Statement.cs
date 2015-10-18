using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Domain.Models
{
    public class Statement
    {
        public DateTime Generated { get; set; }
        public DateTime Due { get; set; }
        public Period Period { get; set; }
    }
}
