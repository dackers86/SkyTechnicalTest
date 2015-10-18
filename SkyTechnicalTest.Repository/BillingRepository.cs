using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkyTechnicalTest.Domain;
using System.IO;
using Newtonsoft.Json;

namespace SkyTechnicalTest.Repository
{
    public class BillingRepository : IBillingRepository
    {
        private Bill _result;
        private string _dataStore = "DataStore";

        public Bill Get(int id)
        {
            try
            {
                using (StreamReader r = new StreamReader(string.Format("{0}/{1}/{2}", AppDomain.CurrentDomain.BaseDirectory,  _dataStore, string.Format("{0}{1}", id, ".json"))))
                {
                    string json = r.ReadToEnd();
                    _result = JsonConvert.DeserializeObject<Bill>(json);
                }
            }
            catch(Exception ex)
            {
                _result = null;
            }

            return _result;
        }
    }
}
