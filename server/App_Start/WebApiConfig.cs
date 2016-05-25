using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AdminLib;
using AdminLib.Data.Adapter.Oracle;

namespace Chinook {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Data Store Adapters
            AdminLib.Data.Adapter.Oracle.Adapter.Declare();

            // Forcing JSON output
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            // NULL values will not be exported in the json
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

        }
    }
}
