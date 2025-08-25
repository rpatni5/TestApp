using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Identity.Client;
using System.Configuration;


namespace TestApp.Services.Services
{
    public class PowerBIService
    {
        private readonly string tenantId;
        private readonly string clientId;
        private readonly string clientSecret;

        public PowerBIService()
        {
            tenantId = ConfigurationManager.AppSettings["TenantId"];
            clientId = ConfigurationManager.AppSettings["ClientId"];
            clientSecret = ConfigurationManager.AppSettings["ClientSecret"];
        }
        public async Task<string> GetAccessTokenAsync()
        {
            var app = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithClientSecret(clientSecret)
                .WithAuthority($"https://login.microsoftonline.com/{tenantId}")
                .Build();

            string[] scopes = { "https://analysis.windows.net/powerbi/api/.default" };
            var authResult = await app.AcquireTokenForClient(scopes).ExecuteAsync();

            return authResult.AccessToken;
        }

        public async Task<JObject> GetReportAsync(string workspaceId, string reportId, string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                string url = $"https://api.powerbi.com/v1.0/myorg/reports/585abcd1-f862-4212-9ee5-98e7d031ba48";

                var response = await client.GetStringAsync(url);
                return JObject.Parse(response);
            }
        }
    }
}