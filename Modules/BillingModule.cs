using Nancy;
using SkyTechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyTechnicalTest.Modules
{
    public class BillingModule : NancyModule
    {
        public BillingModule() : base("/billing")
        {
            Get["/"] = parameters =>
            {
                return Response.AsJson(new Bill());
            };
        }
    }
}