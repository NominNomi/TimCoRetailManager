using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library
{
    public class ConfigHelper
    {
        // TODO: Move this from config to the API
        public static decimal GetTaxRate()
        {

            string rateText = ConfigurationManager.AppSettings["taxRate"];
            //var result = Convert.ToDecimal(rateText);
            bool IsValidTaxRate = Decimal.TryParse(rateText, out decimal result);

            if (IsValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }

            return result;
        }
    }
}
