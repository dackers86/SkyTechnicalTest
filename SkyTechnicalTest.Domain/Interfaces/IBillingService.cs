using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Domain.Interfaces
{
    public interface IBillingService
    {
        Bill Get(int id);
    }
}
