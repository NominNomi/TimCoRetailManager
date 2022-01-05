using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        public decimal GetTaxRate()
        {
            
            string rateText = ConfigurationManager.AppSettings["taxRate"];
            //var result = Convert.ToDecimal(rateText);
            bool IsValidTaxRate = Decimal.TryParse(rateText, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal result);

            if (IsValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }

            return result;
        }
    }
}
