using SkyTechnicalTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkyTechnicalTest.Domain;
using SkyTechnicalTest.Repository;

namespace SkyTechnicalTest.Services
{
    public class BillingService : IBillingService
    {
        private IBillingRepository _billingRepository;

        public BillingService(IBillingRepository billingRepository)
        {
            _billingRepository = billingRepository;
        }

        public Bill Get(int id)
        {
            return _billingRepository.Get(id);
        }
    }
}
