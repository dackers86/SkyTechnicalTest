using SkyTechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Repository
{
    public interface IBillingRepository
    {
        Bill Get(int id);
    }
}
