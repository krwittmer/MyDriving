using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace MyDrivingService.Controllers
{
    /**
     * A first cut to query the API and identify back-end resources.
     * Need to investigate other options to query such API dependency meta-data (leveraging the Azure context).
     */
    public class ConfigInfoController : ApiController
    {
        // GET: api/configinfo
        // TODO: [Authorize]
        public IEnumerable<string> Get()
        {
            return new[]
            {
                "Valid Issuer", ConfigurationManager.AppSettings["ValidIssuer"],
                " | ",
                "Valid Audience", ConfigurationManager.AppSettings["ValidAudience"],
                " | ",
                "IoTHubConnectionString", ConfigurationManager.AppSettings["IoTHubConnectionString"],
                " | ",
                "MS_TableConnectionString", ConfigurationManager.AppSettings["MS_TableConnectionString"],
                " | ",
                "MS_NotificationHubConnectionString", ConfigurationManager.AppSettings["MS_NotificationHubConnectionString"]

            };
        }
    }
}
