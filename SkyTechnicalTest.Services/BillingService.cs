using SkyTechnicalTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkyTechnicalTest.Domain;
using SkyTechnicalTest.Repository;
using FluentValidation;
using SkyTechnicalTest.Validation;

namespace SkyTechnicalTest.Services
{
    public class BillingService : IBillingService
    {
        private IBillingRepository _billingRepository;
        private IValidator<BillValidator> _billValidator;

        public BillingService(IBillingRepository billingRepository, IValidator<BillValidator> billValidator )
        {
            _billingRepository = billingRepository;
            _billValidator = billValidator;
        }

        public Bill Get(int id)
        {
            var bill = _billingRepository.Get(id);

            var validationResult = _billValidator.Validate(bill);

            if (!validationResult.IsValid)
            {
                return null;
            }

            return bill;
        }
    }
}
