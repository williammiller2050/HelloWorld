using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLibrary.Helpers
{
    public class Values
    {
        public static IEnumerable<string> GetValues()
        {
            string baseAddress = GetBaseAddress();

            if (string.IsNullOrWhiteSpace(baseAddress))
                throw new ApplicationException("The base address can not be blank");

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                HttpResponseMessage result = client.GetAsync("api/values").Result;
                return result.Content.ReadAsAsync<IEnumerable<string>>().Result;
            }
        }

        private static string GetBaseAddress()
        {
            if (!ConfigurationManager.AppSettings.HasKeys())
                throw new ApplicationException("Application is not configured correctly.");

            string[] values = ConfigurationManager.AppSettings.GetValues("BaseAddress");
            if (values == null || values.Length == 0)
                throw new ApplicationException("Application needs a base address setting in the app config file.");

            return values[0];
        }
    }
}
