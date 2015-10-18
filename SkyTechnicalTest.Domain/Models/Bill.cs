using SkyTechnicalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Domain
{
    public class Bill
    {
        public Statement Statement { get; set; }
        public Package Package { get; set; }
        public CallCharges CallCharges { get; set; }
        public SkyStore SkyStore { get; set; }


        public double Total { get; set; }
    }
}
